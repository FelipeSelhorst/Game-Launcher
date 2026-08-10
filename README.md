<!-- HEADER -->

<a id="readme-top"></a>

<div align=center>
  <img width="160" height="160" alt="079" src="https://github.com/user-attachments/assets/b7fbea7d-d883-49d1-a266-d70c613ea77a" />
  <br>
  <h1>Slowpoke Launcher</h1>
  <br>
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white"> <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white"> <img src="https://img.shields.io/badge/Steam-000000?style=for-the-badge&logo=steam&logoColor=white">
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li>
          <a href="#current-state">Current State</a>
        </li>
        <li>
          <a href="#how-to-use-it">How To Use It</a>
        </li>
      </ul>
    </li>
    <li>
      <a href="#features">Features</a>
      <ul>
      <li><a href="#current-features">Current Features</a></li>
      </ul>
    <li><a href="#changelog">Changelog</a></li>
    <ul>
      <li><a href="#improved">improved</a></li>
    </ul>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#known-issues">Known Issues</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->

## About The Project

Slowpoke is an open-source, customizable launcher for games and everything around them.

What started as a launcher I made for myself is becoming a project that anyone can customize. The goal is to bring games, applications, friends, news, hardware, and other gaming-related content together in one place.

Because Slowpoke is open source, its interface and functionality can be changed and expanded to fit different needs.

<!-- CURRENT STATE -->

### Current State

Slowpoke is currently in the early prototyping stage. The main focus is on building and testing the launcher's core interface and navigation before moving on to more advanced functionality and customization.

<!-- GIF FROM NOW -->

<img width="408" height="318.5" alt="image" src="https://github.com/user-attachments/assets/ee6e8fb3-00ac-413b-8fb7-9a99ba8f0ae4" />

The current prototype includes the sidebar, Home page navigation, animated selection indicators, and the initial Home layout.
<br>
<br>
<br>
<img width="400.5" height="304.5" alt="Home" src="https://github.com/user-attachments/assets/c49c8c4e-e340-4a39-b294-e11899a19a07"/>

*Early home page prototype. Some elements shown are planned rather than implemented.*

<!-- CORRECT USAGE -->

### How To Use It

The project is currently being tested using real file paths to validate its core launcher functionality.

A downloadable version is not available yet. For now, development is focused on validating the underlying workflow and interface before preparing a usable release.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- FEATURES -->

## Features

<!-- CURRENT FEATURES -->

### Current Features

Sidebar:
- Stylized and animated buttons.
- Animated Selection Indicator.
- Adjustable vertical bar size.

Home Section:
- Page title.
- Stylized header buttons.
- Profile Picture

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- CHANGE LOG -->

## Changelog

<!-- Version -->

### Pre-Release v1.0.0-Beta.1

Sidebar:
- Changed the "Group 1: Home and Library" Buttons to RadioButtons for page navigation.
- Added new styles and animations for the different button types.
- Limited the Selection Indicator only to the Group 1 buttons.
- Adjusted the size and position of the Selection Indicator.

Home Section:
- Added the page title.
- Added main header buttons.
- Created new border and selection effects and animations.
- Added a profile picture.

For more detailed information, see the commit [03e559c](https://github.com/FelipeSelhorst/Game-Launcher/commit/03e559ce90097e843fb7b1cbb4868f86ad722378).

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- IMPROVED -->

### Improved

Sidebar:
- The Selection Indicator now starts on the Home Button when the application launches.
- Group 1 buttons were changed to RadioButtons because they are primarily used for page navigation. This provides a clear indication of the currently selected page, enforces single selection, and simplifies the navigation logic.

Home Section:
- The Home Button is now selected by default when the application launches.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- ROADMAP -->

## Roadmap

### Sidebar
- [ ] Change Logo
- [x] Home Button
- [ ] Library Button
- [ ] Wishlist Pop-Up
- [ ] Friends Pop-Up
- [ ] Configs Button
  - [ ] Turn into RadioButton
- [x] Exit Button
- [x] Selection Indicator

### Home Section
- [ ] Header
  - [x] Page title
  - [x] Main Buttons
  - [ ] Selection Indicator
  - [ ] Round the Profile Picture and add a border
  - [ ] Profile Pop-Up

### Pages
- [ ] Implement Library
- [ ] Implement Patch Notes
- [ ] Implement Performance

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- KNOWN ISSUES -->

## Known Issues

- Page navigation is not fully implemented.
- 4 sidebar buttons are not functional yet.
- The Profile Picture is not properly rounded.
- The logo and application name are still placeholders.
- The Configs button needs to be converted to a RadioButton and connected to its own page.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- CONTACT -->

## Contact

Felipe Selhorst de Lima - [@felipe.selhorst](https://instagram.com/felipe.selhorst) - selhorstdelimafelipe@proton.me

Project Link: [https://github.com/FelipeSelhorst/Game-Launcher](https://github.com/FelipeSelhorst/Game-Launcher)

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>
