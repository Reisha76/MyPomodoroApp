# MyPomodoroApp

MyPomodoroApp is a simple and intuitive Pomodoro Timer application built using C#, Windows Forms, and the .NET Framework. It helps you manage your study or work sessions using the Pomodoro Technique, enhancing your productivity and time management.

## Features

- **Start and Stop Timer**: Easily control your Pomodoro sessions with start and stop functionality.
- **Adjustable Timer Settings**: Customize your study and break durations to fit your schedule.
- **Session Statistics**: Track the number of sessions completed and the total time you've studied.

## Installation

### Requirements

- **Operating System**: Windows 7 or later
- **.NET Framework**: Version 4.7.2 or higher
- **Visual Studio**: (Optional, for building from source)

### Download and Run

1. **Clone or Download the Repository**

   - Clone the repository using Git:
     ```bash
     git clone https://github.com/Reisha76/MyPomodoroApp.git
     ```
   - Or download the ZIP file from the [GitHub repository](https://github.com/Reisha76/MyPomodoroApp) and extract it.

2. **Run the Application**

   - Navigate to the extracted folder.
   - Open the `MyPomodoroApp.exe` file to launch the application.

### Build from Source (Optional)

1. **Open the Solution in Visual Studio**

   - Navigate to the project directory.
   - Open `MyPomodoroApp.sln` with Visual Studio.

2. **Restore NuGet Packages**

   - Visual Studio will automatically restore any missing packages.

3. **Build and Run**

   - Press `F5` or click on **Start** to build and run the application.

## Usage

1. **Start a Session**

   - Click the **Start** button to begin your Pomodoro session.

2. **Adjust Timer Settings**

   - Click the **Settings** button to reveal timer settings.
   - Use the numeric controls to set your desired hours, minutes, and seconds for both study and break periods.
   - Click **Hide Settings** to collapse the settings panel.

3. **Pause or End Session**

   - Click the **Pause** button to pause the timer.
   - Click the **End Period** button to immediately end the current session.

4. **View Statistics**

   - Monitor the number of sessions completed in the **Sessions Counter**.
   - View the total time studied in the **Time Studied** display.

5. **Reset Statistics**

   - Click the **Reset Stats** button to reset your session count and total study time.

## Code Overview

The application's functionality is encapsulated in the `PomodoroApp` class within the `MyPomodoroApp` namespace. Key components include:

- **Timer Management**

  - `startTimer()`: Handles the countdown logic.
  - `updateTimerValue()`: Updates the timer display.

- **Session Control**

  - `startBreakSession()`: Initiates a break period after a study session.
  - `endPomodoroSession()`: Ends the study session and starts a break.
  - `endBreakSession()`: Ends the break session and prepares for the next study session.

- **Statistics Tracking**

  - `updateTimeStudied()`: Updates the total time studied.
  - `getTimeStudied()`: Calculates the cumulative study time.

- **User Interface**

  - Event handlers for button clicks and value changes to interact with the UI components.

