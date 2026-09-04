<!-- HEADER -->

<a id="readme-top"></a>

<div align=center>
  <img width="207" height="200" alt="gato guerra" src="https://github.com/user-attachments/assets/7fa965b5-7c95-4fcb-951b-56679be041f8" />
  <br>
  <h1>Game Launcher</h1>
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
<br>
<br>
<br>

<!-- ABOUT THE PROJECT -->

## About The Project

An open-source, customizable launcher that brings games, applications, friends, news, hardware information, and other gaming-related content together in one place.

Its open architecture allows the interface and functionality to be freely customized and extended to fit different needs.

<!-- CURRENT STATE -->

### Current State

The project is currently in early pre-release development, with the focus on building and validating the launcher's core interface and navigation.

The current prototype includes the sidebar, header layout, animated selection indicators and a profile popup for changing the user's nickname and profile picture.

<!-- GIF FROM NOW -->

<img width="397" height="304.5" alt="gif" src="README Files/Launcher.gif"/><br>
*Gif of the current state.*
<br>
<br>
<br>
<img width="400.5" height="304.5" alt="Home Prototype" src="README Files/Home.png"/><br>
*Early home page design prototype. Some elements shown are planned and not yet implemented. The design and features are subject to change.*

<!-- CORRECT USAGE -->

### How To Use It

The project is currently in pre-release alpha and is not yet available as a public download.

Development is focused on validating the core interface and workflow before an official release. <strong>Release date: TBA<strong>.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- FEATURES -->

## Features

<!-- CURRENT FEATURES -->

### Current Features

Sidebar:
- Stylized and animated buttons
- Animated selection indicator
- Adjustable width
- Exit button

Header:
- Page title
- Profile Popup
- Profile picture customization
- Local profile data persistence

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- ROADMAP -->

## Roadmap

Development is tracked through the [Roadmap Website](https://launcher-roadmap.vercel.app/), which contains current work, shipped features, and planned ideas.

### General
- [ ] Give a name to the project
- [ ] Change logo
- [ ] Change main font
  - [x] Add the font Montserrat
  - [ ] Make the new font default in the entire application
- [ ] Move each attribute to its own file

### Sidebar
- [x] Home
- [ ] Library
- [ ] Wishlist
- [ ] Friends
- [ ] Configurations
- [x] Exit
- [x] Selection indicator

### Pages
- [x] Change Sidebar to `UserControl`
- [ ] Change Home to `UserControl`
- [ ] Implement Library
- [ ] Implement Patch Notes
- [ ] Implement Performance
- [ ] Implement Configurations

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- CHANGE LOG -->

## Changelog

<!-- Version -->

### Latest Update

<h3>Pre-Release v0.4.0-alpha.5.0</h3>

- Refactored the Sidebar into its own `UserControl`.
- Added persistent profile data.
- Added profile picture selection and local storage.
- Added nickname persistence and display.
- Improved the page title and profile integration.
- Added a maximum width to the Sidebar.
- Cleaned up unused files and code.
- Added XML labels throughout the interface to improve code readability.

For the complete development history, see the commit [9e8864b](https://github.com/FelipeSelhorst/Game-Launcher/commit/9e8864b88e98f0bb3b02fec66ff365ea1f193238).

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
- Improved performance by separating the Sidebar from the MainWindow.

Home Section:
- The profile picture is rounded and features visual indicators showing that it can and has been selected.
- Now the displayed profile picture is the one selected by the user.
- The page title now displays the nickname alongside its content.

Popup:
- Finished the `SaveProfile` function.
- Added an option to change the profile picture and save it locally.
- Now the nickname is saved and displayed whenever the application is open.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- KNOWN ISSUES -->

## Known Issues
- The application logo is still a placeholder.
- Page navigation is not fully implemented.
- Several sidebar buttons are not yet functional.
- Montserrat is not set yet as the application-wide default font.
- The codebase still needs further optimization and cleanup.

Issues that are easier or quicker to address are more likely to be fixed in the next update. More complex issues may be addressed in future larger updates.

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>

<!-- CONTACT -->

## Contact

Felipe Selhorst de Lima - [@felipe.selhorst](https://instagram.com/felipe.selhorst) - selhorstdelimafelipe@proton.me

Project Link: [https://github.com/FelipeSelhorst/Game-Launcher](https://github.com/FelipeSelhorst/Game-Launcher)

<p align="right">(<a href="#readme-top">Back To Top</a>)</p>
