# DatingApp

DatingApp is a web application for connecting people. It allows users to create profiles, upload photos, and interact with other users through messages and likes.

## Table of Contents

- [Features](#features)
- [Technologies](#technologies)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

- User authentication and authorization
- Profile creation and editing
- Photo upload and management
- Messaging between users
- Like and match functionality
- Error handling and logging

## Technologies

- **Frontend:**
  - Angular
  - Bootstrap
  - Ngx-Bootstrap
  - Ngx-Gallery
  - Ngx-File-Upload

- **Backend:**
  - ASP.NET Core
  - Entity Framework Core
  - SQLite

## Installation

### Prerequisites

- Node.js and npm
- .NET SDK

### Backend

1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/DatingApp.git
   cd DatingApp
   ```
2. Navigate to the API project directory:
   ```sh
   cd API
   ```
3. Restore the dependencies:
   ```sh
   dotnet restore
   ```
4. Update the database:
   ```sh
   dotnet ef database update
   ```
5. Run the backend server:
   ```sh
   dotnet run
   ```

### Frontend

1. Navigate to the client project directory:
   ```sh
   cd client
   ```
2. Install the dependencies:
   ```sh
   npm install
   ```
3. Run the frontend server:
   ```sh
   ng serve
   ```
4. Open your browser and navigate to:
   ```sh
   http://localhost:4200
   ```

## Usage

1. Register a new user or log in with an existing account.
2. Create and edit your profile.
3. Upload photos to your profile.
4. Browse other users' profiles.
5. Like and message other users.

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch:
   ```sh
   git checkout -b feature/your-feature
   ```
3. Commit your changes:
   ```sh
   git commit -m 'Add some feature'
   ```
4. Push to the branch:
   ```sh
   git push origin feature/your-feature
   ```
5. Open a pull request.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

