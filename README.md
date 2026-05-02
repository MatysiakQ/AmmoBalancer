<div align="center">

# 🔫 FreshAmmoRules

**Zaawansowany system zarządzania gospodarką amunicją dla serwerów SCP: Secret Laboratory.**

[![Release](https://img.shields.io/badge/Release-v2.0.0-blue.svg?style=flat-square)](#)
[![EXILED](https://img.shields.io/badge/EXILED-v9.13.2-yellow.svg?style=flat-square)](#)
[![.NET](https://img.shields.io/badge/.NET-8.0-purple.svg?style=flat-square)](#)
[![License](https://img.shields.io/badge/License-MIT-green.svg?style=flat-square)](LICENSE)

</div>

<hr>

## 📑 Spis treści
- [O projekcie](#-o-projekcie)
- [Główne funkcje](#-główne-funkcje)
- [Instalacja](#-instalacja)
- [Konfiguracja](#-konfiguracja)
- [Kompilacja ze źródeł](#-kompilacja-ze-źródeł)
- [Zgłaszanie błędów](#-zgłaszanie-błędów)
- [Licencja](#-licencja)

---

## 📖 O projekcie

**FreshAmmoRules** rozwiązuje jeden z głównych problemów na serwerach SCP:SL – masowe chomikowanie amunicji przez graczy. Wtyczka pozwala na wprowadzenie sztywnych limitów w ekwipunku, jednocześnie poprawiając balans gry na wczesnym etapie rundy poprzez wsparcie klasy Facility Guard. 

Plugin został napisany z naciskiem na optymalizację i czystość kodu (Single Responsibility Principle), dzięki czemu nie obciąża serwera nawet przy pełnym obłożeniu graczy.

---

## ✨ Główne funkcje

* **🛡️ Dynamiczna alokacja dla Ochrony (Guard Support):** Automatycznie przyznaje zdefiniowaną w configu ilość amunicji każdemu Ochroniarzowi natychmiast po jego zrespieniu (opóźnienie 1.5s gwarantuje kompatybilność z domyślnym systemem gry).
* **⛔ System Anti-Hoard:** Bezwzględnie egzekwuje maksymalne limity noszonej amunicji dla frakcji MTF oraz Chaos Insurgency.
* **⚡ Hot-Reload (Live Config):** Wtyczka obsługuje przeładowywanie konfiguracji w locie. Zmiana limitów nie wymaga restartowania całego serwera.
* **🪶 Lekkość i stabilność:** Kompatybilność z systemem `Separated Configs` w EXILED oraz brak zbędnych bibliotek zewnętrznych gwarantują najwyższą wydajność.

---

## 📥 Instalacja

Wtyczka działa w oparciu o framework **EXILED** i nie wymaga żadnych dodatkowych zależności.

1. Przejdź do zakładki **Releases** na tym repozytorium.
2. Pobierz najnowszy plik `FreshAmmoRules.dll`.
3. Skopiuj plik do folderu z pluginami na swoim serwerze (najczęściej jest to `%appdata%/EXILED/Plugins`).
4. Zrestartuj serwer lub wpisz komendę `p reload` w konsoli Remote Admin.

> **Wymagania systemowe:** 
> - SCP: Secret Laboratory (najnowsza wersja)
> - EXILED (v9.13.2 lub nowsza)

---

## ⚙️ Konfiguracja

Po pierwszym uruchomieniu wtyczki, system wygeneruje konfigurację. Znajdziesz ją w folderze `Configs/Plugins/fresh_ammo/global.yml` (lub w głównym pliku konfiguracyjnym portu, w zależności od ustawień EXILED).
```yaml
fresh_ammo:
  # Czy plugin jest włączony? [Domyślnie: true]
  is_enabled: true
  
  # Czy pokazywać szczegółowe logi w konsoli? [Domyślnie: false]
  debug: false
  
  # Dodatkowa amunicja przyznawana Ochroniarzowi (Facility Guard) na start
  guard_extra_ammo: 30
  
  # --- MAKSYMALNE LIMITY AMUNICJI --- #
  
  # Karabin MTF (5.56)
  max_ammo556: 200
  
  # Karabin Chaos Insurgency (7.62)
  max_ammo762: 200
  
  # Pistolet maszynowy / Pistolet (9mm)
  max_ammo9mm: 200
  
  # Strzelba (12 Gauge)
  max_ammo12_gauge: 54
  
  # Rewolwer (.44 Cal)
  max_ammo44_cal: 48
```

---

## 🔨 Kompilacja ze źródeł

Jeśli chcesz samodzielnie skompilować projekt (np. w celu wprowadzenia własnych modyfikacji):

1. Sklonuj repozytorium:
   ```bash
   git clone [https://github.com/TwojaNazwaUzytkownika/FreshAmmoRules.git](https://github.com/TwojaNazwaUzytkownika/FreshAmmoRules.git)
   ```
2. Otwórz projekt w **Visual Studio 2022**.
3. Upewnij się, że posiadasz zainstalowany `.NET 8.0 SDK`.
4. Pobierz pakiety NuGet dla `EXILED`.
5. Skompiluj projekt w trybie `Release` (Skrót: `Ctrl + Shift + B`).
6. Gotowy plik `.dll` znajdziesz w folderze `bin/Release/net8.0/`.

---

## 🐛 Zgłaszanie błędów i propozycje

Jeśli znalazłeś błąd lub masz pomysł na nową funkcję, śmiało otwórz nowe zgłoszenie w zakładce **Issues**. Pull Requesty z optymalizacjami są również mile widziane!

---

## 📜 Licencja

Ten projekt jest objęty licencją **MIT**. Szczegóły znajdziesz w pliku `LICENSE`.

<div align="center">
  Stworzone z ❤️ przez <b>Matysiaka</b>.
</div>
