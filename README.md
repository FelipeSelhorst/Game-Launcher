<!-- HEADER -->

<a id="readme-top"></a>

<div align=center>
  <img width="160" height="160" alt="079" src="README Files/Slowpoke.png" />
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
      <li><a href="#latest-update">Latest Update</a></li>
      <li><a href="#previous-update">Previous Update</a></li>
      <li><a href="#improved">Improved</a></li>
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

<img width="397" height="304.5" alt="gif" src="README Files/Launcher.gif"/><br>
*Gif of the current state.*

The current protorype includes the sidebar, Home page layout, animated selection indicators, and a profile popup to change the user's nickname.
<br>
<br>
<br>
<img width="400.5" height="304.5" alt="Home Prototype" src="README Files/Home.png"/><br>
*Early home page prototype. Some elements shown are planned and not yet implemented. The design and features are subject to change.*

<!-- CORRECT USAGE -->

### How To Use It

The project is currently on its pre-release alpha and being tested to validate its core functionality as a Game Launcher.

A downloadable version is not available until the official release (TBA). For now, development is focused on validating the underlying workflow and interface before preparing a public release.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- FEATURES -->

## Features

<!-- CURRENT FEATURES -->

### Current Features

Sidebar:
- Stylized and animated buttons.
- Animated Selection Indicator.
- Adjustable vertical bar size.
- Exit button.

Home Section:
- Page title.
- Stylized header buttons.
- Profile Popup.
- Option to change the username.
- New font added.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- CHANGE LOG -->

## Changelog

<!-- Version -->

### Latest Update

<h3>Pre-Release v0.3.0-alpha.4.0</h3>

General:
- Useless files were deleted.

Home Section:
- Rounded the profile picture.
- Added a stylized border around the profile button.
- Changed the profile button to `ToggleButton`.

Profile Popup:
- Changed the text over the input from "Name" to "Nickname" and aligned it to the input text.
- Changed the background and text color of the nickname input field.
- Changed the popup size and added a new row to the bottom.
- Added the button "Save Changes" to the new row.
- Increased the profile image size.
- Centered the input and its label.
- Added styles and animations to the new button.

For more detailed information, see the commit [d558246](https://github.com/FelipeSelhorst/Game-Launcher/commit/d558246da83b4ec94bcd57c6f6a22a02c86e51f3)

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>
<br>

### Previous Update

<h3>Pre-Release v0.2.1-alpha.3.0</h3>

General:
- Added the font "Montserrat" to the project.

Home Section:
- Changed the page title and buttons font.
- Corrected the column widths.
- Corrected the issue where the profile button was not displaying the image correctly.

Profile Popup:
- Corrected the issue where the popup was not displaying anything.
- Increased the size.
- Added columns and rows.
- Added the profile picture to the left.
- Added a `<TextBlock>` to label the "Name" field.
- Added an input to change the username.

For more detailed information, read the commit [bb76571](https://github.com/FelipeSelhorst/Game-Launcher/commit/bb76571b9d385b8a011cbb6eb45701c6bab67125)

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- IMPROVED -->

### Improved

General:
- Reduced the application's folder size.

Home Section:
- The profile picture is rounded and features visual indicators showing that it can and has been selected.

Popup:
- Added the missing "Save Changes" button.
- Added a new row exclusively for the new button.
- Increased sizes and centered the elements.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- ROADMAP -->

## Roadmap

### General
- [x] Change Name
- [ ] Change Logo
- [ ] Change Main Font
  - [x] Add the New Font
  - [ ] Make the New Font Default for the Entire Project

### Sidebar
- [x] Home Button
- [ ] Library Button
- [ ] Wishlist Pop-Up
  - [ ] Change to ToggleButton
- [ ] Friends Pop-Up
  - [ ] Change to ToggleButton
- [ ] Configs Button
  - [x] Turn to RadioButton
- [x] Exit Button
- [x] Selection Indicator

### Home Section
- [ ] Header
  - [x] Page title
  - [x] Main Buttons
  - [ ] Selection Indicator
  - [x] Round the Profile Picture and add a border
  - [ ] Profile Pop-Up
    - [x] Save Button
    - [ ] Option to Change Picture
    - [x] Option to Change Name

### Pages
- [ ] Change Home code for its actual file.
- [ ] Implement Library
- [ ] Implement Patch Notes
- [ ] Implement Performance
- [ ] Implement Configurations

Please consider taking a look at the [Roadmap Website](https://felipeselhorst.github.io/Launcher-Roadmap) to see what we are currently working on, every shipped feature and planned ideas.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- KNOWN ISSUES -->

## Known Issues

**Sorted by Expected Fix**

- The `SaveProfile` property has not been implemented yet.
- The name-changing feature is not functional.
- The application logo is still a placeholder.
- Page navigation is not fully implemented.
- Four sidebar buttons are not functional.
- The added font, "Montserrat", is not set as the application default.
- The code needs to be optimized and cleaned up.

Issues that are easier or quicker to address are more likely to be fixed in the next update. More complex issues may be addressed in future larger updates.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- CONTACT -->

## Contact

Felipe Selhorst de Lima - [@felipe.selhorst](https://instagram.com/felipe.selhorst) - selhorstdelimafelipe@proton.me

Project Link: [https://github.com/FelipeSelhorst/Game-Launcher](https://github.com/FelipeSelhorst/Game-Launcher)

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>
