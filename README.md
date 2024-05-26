# DBMIDProject-2022-CS-177

# Final Year Project Management System

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Reports](#reports)
- [Libraries Used](#libraries-used)
- [Contributing](#contributing)
- [License](#license)

## Introduction

The Final Year Project Management System is a desktop application developed using Windows Form Application in C#. The system aims to streamline the process of managing final year projects at the Department of Computer Science, UET Lahore. It provides a centralized platform for the project committee to handle various aspects of project management, including student and advisor management, project assignment, evaluations, and report generation.

## Features

1. **Manage Students:**
   - Add, edit, or delete student information.
   - View a list of all students.

2. **Manage Advisors:**
   - Add, edit, or delete advisor information.
   - View a list of all advisors.

3. **Manage Projects:**
   - Add, edit, or delete project details.
   - View a list of all projects.

4. **Formation of Student Group and its Management:**
   - Create and manage student groups for projects.
   - Assign or remove students from groups.

5. **Assignment of Project to a Group of Students:**
   - Assign projects to student groups.
   - View project assignments.

6. **Assignment of Multiple Advisors to the Project:**
   - Assign main advisor, co-advisor, and industry advisor to a project.

7. **Manage Evaluations:**
   - Record and track multiple evaluations against each project.
   - View evaluation history.

8. **Mark the Evaluations Against a Group:**
   - Enter and view evaluation marks for each group.

9. **Additional Features:**
   - Discussions with the committee to incorporate any other features deemed necessary.

## Installation

1. Clone the repository to your local machine.
   ```
   git clone https://github.com/your-username/final-year-project-management.git
   ```

2. Open the project in Visual Studio.

3. Install the necessary NuGet packages for iTextSharp and FontAwesome.

4. Build and run the application.

## Usage

1. **Login:**
   - Use the provided credentials to log in.

2. **Dashboard:**
   - Access the main features through the dashboard.

3. **Navigation:**
   - Use the sidebar to navigate between different sections.

4. **Data Entry:**
   - Enter and update information using the respective forms.

5. **Reports:**
   - Generate PDF reports using the iTextSharp library for report generation and FontAwesome for tools.

## Reports

The system supports the following reports in PDF format using iTextSharp:

1. **List of Projects:**
   - Includes advisory board details and a list of students for each project.

2. **Marks Sheet of Projects:**
   - Shows marks in each evaluation against each student and project.

## Libraries Used

- [iTextSharp](https://github.com/itext/itext7): Used for generating PDF reports.
- [FontAwesome](https://fontawesome.com/): Used for incorporating icons and tools.

## Contributing

If you have suggestions or want to contribute to the project, feel free to open an issue or create a pull request. Your feedback and contributions are highly appreciated.

## License

This project is licensed under the [MIT License](LICENSE). Feel free to use, modify, and distribute the code.
