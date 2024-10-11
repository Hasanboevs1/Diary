# Diary Management System

# Overview

The Diary Management System is a simple web application for managing diaries. It allows users to create, edit, view, and delete diary entries. The application is built with **ASP.NET Core** for the backend and **Bootstrap** for the frontend design. Users can add diary titles, content, and manage their entries with ease.

# Features

- **Create**: Add a new diary entry with a title and content.
- **Edit**: Update an existing diary entry.
- **View**: Read diary entries with detailed content.
- **Delete**: Remove a diary entry.
- **Search**: Search diary entries by title.
  
# Technologies Used

- **ASP.NET Core** (Backend)
- **Bootstrap** (Frontend Styling)
- **Entity Framework Core** (Database ORM)
- **FontAwesome** (Icons)

# Installation

To run the project locally, follow these steps:

# Prerequisites
- **.NET SDK** (7.0 or later)
- **Visual Studio** or **Visual Studio Code**
- **SQL Server** or another database provider (depending on your configuration)

# Steps

1. **Clone the Repository**  
   First, clone the repository to your local machine:
   ```bash
   git clone https://github.com/your-username/diary-management.git
   cd diary-management
   ```

2. **Install Dependencies**  
   Restore the necessary packages for the project:
   ```bash
   dotnet restore
   ```

3. **Update Database**  
   Ensure the database is created and updated by running:
   ```bash
   dotnet ef database update
   ```

4. **Run the Application**  
   Run the application using the following command:
   ```bash
   dotnet run
   ```

5. **Access the Application**  
   Once the application is running, you can access it at:
   ```
   http://localhost:5000
   ```

# Screenshots

Here’s a sample screenshot of the **Diary Management System** interface:

![Diary Management Screenshot](images/diary-screenshot.png)

# Usage

# Creating a New Diary
1. Click on the "Add New Diary" button.
2. Enter a title and content for your diary.
3. Click "Create" to save the new diary entry.

# Editing an Existing Diary
1. Click the "Edit" button next to the diary entry you want to update.
2. Modify the title or content as needed.
3. Click "Save Changes" to update the diary.

# Deleting a Diary Entry
1. Click the "Delete" button next to the diary you wish to delete.
2. Confirm the deletion when prompted.

# Searching Diaries
- Use the search bar to find diary entries by title.

# Contributing

If you'd like to contribute to this project, feel free to fork it, submit a pull request, or open issues for suggestions or bug reports.

# License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.


Steps to Complete the README:

1. Update the GitHub URL In the **Clone the Repository** section, replace `https://github.com/your-username/diary-management.git` with your actual repository URL.
   
2. Add an Image
    - Place a screenshot of your app in the `/images` folder within your project.
    - The screenshot can be named `diary-screenshot.png` or any name you prefer. 
    - The line `![Diary Management Screenshot](images/diary-screenshot.png)` will display this image in the **README.md** when viewed on GitHub or any markdown viewer.

3. License File: Make sure to include a `LICENSE` file in your repository. You can find a template for the MIT License [here](https://opensource.org/licenses/MIT). 
