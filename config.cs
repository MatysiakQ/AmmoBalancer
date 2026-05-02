using Exiled.API.Interfaces;

namespace MatysiakAmmoWipe
{
    public class Config : IConfig
    {
        /// <summary>
        /// Czy plugin jest włączony?
        /// </summary>
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Czy pokazywać logi debugowania?
        /// </summary>
        public bool Debug { get; set; } = false;

        /// <summary>
        /// Ile dodatkowej amunicji dostaje Ochroniarz na start?
        /// </summary>
        public ushort GuardExtraAmmo { get; set; } = 30;

        /// <summary>
        /// Maksymalny limit amunicji dla karabinów MTF (5.56)
        /// </summary>
        public ushort MaxAmmo556 { get; set; } = 200;

        /// <summary>
        /// Maksymalny limit amunicji dla karabinów Chaosu (7.62)
        /// </summary>
        public ushort MaxAmmo762 { get; set; } = 200;

        /// <summary>
        /// Maksymalny limit amunicji dla pistoletów maszynowych (9mm)
        /// </summary>
        public ushort MaxAmmo9mm { get; set; } = 200;

        /// <summary>
        /// Maksymalny limit amunicji dla strzelb (12 Gauge)
        /// </summary>
        public ushort MaxAmmo12Gauge { get; set; } = 54;

        /// <summary>
        /// Maksymalny limit amunicji dla rewolwerów (.44 Cal)
        /// </summary>
        public ushort MaxAmmo44Cal { get; set; } = 48;
    }
}