using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;
using System;

namespace MatysiakAmmoWipe
{
    public class FreshAmmoPlugin : Plugin<Config>
    {
        public override string Name => "FreshAmmoRules";
        public override string Author => "Matysiak";
        public override Version Version => new Version(2, 0, 0);
        public override string Prefix => "fresh_ammo";

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Spawned += OnSpawned;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Spawned -= OnSpawned;
            base.OnDisabled();
        }

        private void OnSpawned(SpawnedEventArgs ev)
        {
            // Zabezpieczenie przed błędami, gdy gracz lub jego rola nie istnieje
            if (ev.Player == null || ev.Player.Role == null) return;

            Team team = ev.Player.Role.Team;
            RoleTypeId role = ev.Player.Role.Type;

            // Plugin dotyczy tylko sił Fundacji i Rebelii Chaosu
            if (team != Team.FoundationForces && team != Team.ChaosInsurgency)
                return;

            // Opóźnienie 1.5s pozwala grze na przydzielenie domyślnych przedmiotów
            Timing.CallDelayed(1.5f, () =>
            {
                if (ev.Player == null || !ev.Player.IsAlive) return;

                foreach (var item in ev.Player.Items)
                {
                    if (item is Firearm firearm)
                    {
                        AmmoType ammoType = (AmmoType)firearm.AmmoType;

                        if (role == RoleTypeId.FacilityGuard)
                        {
                            // Ochroniarz dostaje dodatkową pulę z configu
                            ev.Player.AddAmmo(ammoType, Config.GuardExtraAmmo);
                        }
                        else
                        {
                            // Reszta klas otrzymuje sztywny limit z configu
                            ushort maxAmmo = GetMaxAmmoLimit(ammoType);
                            ev.Player.SetAmmo(ammoType, maxAmmo);
                        }
                    }
                }
            });
        }

        private ushort GetMaxAmmoLimit(AmmoType ammoType)
        {
            switch (ammoType)
            {
                case AmmoType.Nato556: return Config.MaxAmmo556;
                case AmmoType.Nato762: return Config.MaxAmmo762;
                case AmmoType.Nato9: return Config.MaxAmmo9mm;
                case AmmoType.Ammo12Gauge: return Config.MaxAmmo12Gauge;
                case AmmoType.Ammo44Cal: return Config.MaxAmmo44Cal;
                default: return 0;
            }
        }
    }
}