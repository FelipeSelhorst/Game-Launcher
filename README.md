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
      <li><a href="#latest-update">Latest Update</a></li>
      <li><a href="#previous-update">Previous Update</a></li>
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

<img width="397" height="304.5" alt="image" src="https://github.com/user-attachments/assets/6d2b1e53-f9d7-43ec-8bd8-831b43dd1b51"/><br>
The current prototype includes the sidebar, Home page navigation, animated selection indicators, and the initial Home layout.
<br>
<br>
<br>
<img width="400.5" height="304.5" alt="Home" src="https://github.com/user-attachments/assets/c49c8c4e-e340-4a39-b294-e11899a19a07"/><br>
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
- Profile Popup.
- Option to change the username.
- New font added.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- CHANGE LOG -->

## Changelog

<!-- Version -->

### Latest Update

<h3>Pre-Release v0.2.1-alpha.3.0</h3>

General:
- Added the font "Montserrat" to the project.

Home Section:
- Changed the page title and buttons font.
- Corrected the column widths.
- Corrected the issue where the profile button was not displaying the image correctly.

Profile Popup:

/// The previous lines regarding the popup did not work, so they were deleted. ///
- Corrected the issue where the popup was not displaying anything.
- Increased the size.
- Added columns and rows.
- Added the profile picture to the left.
- Added a `<TextBlock>` to label the "Name" field.
- Added an input to change the username.

For more detailed information, read the commit [bb76571](https://github.com/FelipeSelhorst/Game-Launcher/commit/bb76571b9d385b8a011cbb6eb45701c6bab67125)

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>
<br>

### Previous Update

<h3>Pre-Release v0.2.0-alpha.2.0</h3>

General:
- Changed the application name to "Slowpoke Launcher".

Sidebar:
- Changed the Configs button to RadioButton.
- Extended the Selection Indicator to include Configs Button.

Home Section:
- Replaced the profile picture with a button that opens a profile popup.
- Added an option for changing the username.

For more detailed information, see the commit [ef9d055](https://github.com/FelipeSelhorst/Game-Launcher/commit/ef9d0551b28ec9fa79e78f68df0d034a0d594ebf).

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- IMPROVED -->

### Improved

Home Section:
- The columns are now more responsive.

Popup:
- The Profile Popup now displays the profile picture and have an option to change the username.
- Rows and columns were added to adjust better the objects position.

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
- [ ] Friends Pop-Up
- [ ] Configs Button
  - [x] Turn into RadioButton
- [x] Exit Button
- [x] Selection Indicator

### Home Section
- [ ] Header
  - [x] Page title
  - [x] Main Buttons
  - [ ] Selection Indicator
  - [ ] Round the Profile Picture and add a border
  - [ ] Profile Pop-Up
    - [ ] Save Button
    - [ ] Option to Change Picture
    - [x] Option to Change Name 

### Pages
- [ ] Implement Library
- [ ] Implement Patch Notes
- [ ] Implement Performance
- [ ] Implement Configurations

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- KNOWN ISSUES -->

## Known Issues

- Page navigation is not fully implemented.
- 4 sidebar buttons are not functional.
- The Profile Picture is not properly rounded.
- The application logo is still a placeholder.
- The "SaveProfile" property does not have any code yet.
- The "Save" button is missing on the Popup.
- The name changing feature does nothing.
- The added font "Montserrat" is not set as the application default.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- CONTACT -->

## Contact

Felipe Selhorst de Lima - [@felipe.selhorst](https://instagram.com/felipe.selhorst) - selhorstdelimafelipe@proton.me

Project Link: [https://github.com/FelipeSelhorst/Game-Launcher](https://github.com/FelipeSelhorst/Game-Launcher)

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>
