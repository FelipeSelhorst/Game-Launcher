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

<!-- HIATUS -->

# HIATUS

We are pausing development for a while. Lately, building this launcher has hit a few snags due to my own ongoing learning curve with C# and XAML, and I need to step back for a moment to catch up and build my confidence to guarantee a well-developed application.

We don't expect this hiatus to last indefinitely, but upcoming features will be delayed by at least a quarter. Thank you for your patience and support.

We'll post another update when things kick back into gear.

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
- Option to change the nickname and profile picture.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- CHANGE LOG -->

## Changelog

<!-- Version -->

### Latest Update

<h3>Pre-Release v0.4.0-alpha.5.0</h3>

General:
- Removed more useless files.
- Removed the function `TextChanged`.
- Created a dedicated `UserControl` for the sidebar.
- Changed the sidebar code content from MainWindow (.xaml & .xaml.cs) to Sidebar (.xaml & .xaml.cs).
- Adapted the sidebar behind-code and grids to its new file.
- Labeled every XML element to facilitate understanding of the code.

Sidebar:
- Set a limit on how wide the `GridSplitter` can make the Sidebar be.

Home Section:
- Changed the profile picture placeholder to the one selected by the user.
- Changed the page title text to the placeholder "Hello, User!" in cases where the user has not chosen a nickname.
- Made the page title display the selected nickname alongside its content.
- Reduced the page title's font size to fit better the screen.

Pop-Up:
- Changed the profile `<Image>` to a `Button`.
- Created a function to change the profile picture.
- Created a function to get the selected profile picture directory and save a local copy on %LOCALAPPDATA%/Slowpoke Launcher/Profile.
- The nickname feature was changed to also be able to save locally.
- Created a function to load locally saved information and display them even after a restart.
- Finished the function `SaveProfile` and attached it to its button.

For more detailed information, see the commit [9e8864b](https://github.com/FelipeSelhorst/Game-Launcher/commit/9e8864b88e98f0bb3b02fec66ff365ea1f193238).

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>
<br>

### Previous Update

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

For more detailed information, see the commit [e548af6](https://github.com/FelipeSelhorst/Game-Launcher/commit/e548af646037fe3adacc755f5f81235d3d36efed)

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- IMPROVED -->

### Improved

General:
- Improved the performance by separating the Sidebar from the MainWindow.

Home Section:
- The profile picture is rounded and features visual indicators showing that it can and has been selected.
- Now the displayed profile picture is the one selected by the user.
- The page title now displays the nickname alongside its content.

Popup:
- Finished the `SaveProfile` function.
- Added an option to change the profile picture and save it locally.
- Now the nickname is saved and displayed whenever the application is open.

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
  - [x] Profile Pop-Up
    - [x] Save Button
    - [x] Option to Change Picture
    - [x] Option to Change Name

### Pages
- [x] Change Sidebar to UserControl.
- [ ] Change Home to UserControl.
- [ ] Implement Library
- [ ] Implement Patch Notes
- [ ] Implement Performance
- [ ] Implement Configurations

<br>
Please consider taking a look at the [Roadmap Website](https://felipeselhorst.github.io/Launcher-Roadmap) to see what we are currently working on, every shipped feature and planned ideas.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- KNOWN ISSUES -->

## Known Issues

**Sorted by Expected Fix**

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
