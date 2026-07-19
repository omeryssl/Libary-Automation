# Library Management System

## Overview

Library Management System is a C# Windows Forms learning project built on .NET Framework 4.7.2. It uses ADO.NET with SQL Server to manage books, members, and loan records.

The application provides separate administrator and member flows. Administrator screens manage library data, while member screens display books and the signed-in member's loan records.

## Main Features

- Administrator and member sign-in flows
- Book add, list, update, and delete operations
- Member add, list, update, and delete operations
- Loan add, list, update, and delete operations
- Book search by title and author
- Book filtering by category
- Member search by name
- Loan filtering by date range
- QR and Code 128 barcode generation
- Camera-based barcode scanning for book lookup
- Member views for books and loan records

> The current authentication flow is intended only for an isolated local demonstration. It must not be described as secure authentication.

## Technologies

- C#
- Windows Forms
- .NET Framework 4.7.2
- Microsoft SQL Server
- ADO.NET (System.Data.SqlClient)
- ZXing.Net 0.16.9
- Zen.Barcode
- AForge 2.2.5

## Architecture and Structure

The repository contains one Windows Forms project with a form-per-operation structure. UI forms currently open SQL Server connections and execute ADO.NET commands directly.

- Otomasyon/Kütüphane_Otomasyonu/giris.cs — administrator/member sign-in
- Otomasyon/Kütüphane_Otomasyonu/anaSayfa.cs — administrator dashboard
- Otomasyon/Kütüphane_Otomasyonu/UyeAnaSayfa.cs — member dashboard
- Otomasyon/Kütüphane_Otomasyonu/kitap*.cs — book operations and search
- Otomasyon/Kütüphane_Otomasyonu/uye*.cs — member operations and search
- Otomasyon/Kütüphane_Otomasyonu/emanet*.cs — loan operations and filtering
- Otomasyon/Kütüphane_Otomasyonu/KitapQr.cs — QR and barcode generation
- Otomasyon/kutuphane.bacpac — current SQL Server database package

## Prerequisites

- Windows
- Visual Studio with .NET desktop development tools
- .NET Framework 4.7.2 Developer Pack
- Microsoft SQL Server and SQL Server Management Studio or compatible BACPAC import tooling
- A camera for the optional barcode-scanning flow

## Installation

1. Clone the repository:

   ~~~text
   git clone https://github.com/omeryssl/Libary-Automation.git
   ~~~

2. Open Otomasyon/Kütüphane_Otomasyonu.sln in Visual Studio.
3. Restore the NuGet packages referenced by packages.config.
4. Prepare a local SQL Server database using only sanitized fictional demo data.
5. Configure the application for your local SQL Server instance without committing private connection details.

## Database Setup

The current repository includes Otomasyon/kutuphane.bacpac. The package contains book, member, stock, and loan table data and must be treated as potentially sensitive until it has been reviewed and replaced with a sanitized demo package.

For a public portfolio version:

1. Import only a sanitized BACPAC containing fictional records.
2. Do not publish real member names, national identifiers, phone numbers, email addresses, postal addresses, or loan history.
3. Do not use real credentials as demo accounts.

## Configuration

The current implementation contains local SQL Server connection strings in multiple source and configuration files. This is a portability and security limitation. Use a private local configuration for testing and never commit machine-specific endpoints or credentials.

The existing administrator values must be treated only as local demonstration credentials. They are intentionally not reproduced in this README. A public demo should use clearly labeled fictional credentials supplied through a safe local setup process.

## How to Run

1. Start SQL Server and confirm that the sanitized demo database is available.
2. Open the solution in Visual Studio.
3. Select Kütüphane_Otomasyonu as the startup project.
4. Build and run the Windows Forms application.
5. Use fictional local demo accounts to review the administrator and member flows.

## Screenshots

No recruiter-facing screenshots are currently committed. Planned images will be stored under docs/images/:

- sign-in.png
- admin-dashboard.png
- member-dashboard.png
- book-list-search.png
- member-list-search.png
- loan-list.png
- qr-barcode-generator.png

## Known Limitations

- Authentication uses local demonstration values and is not secure authentication
- Member identifiers are used as sign-in values
- Remember-me values are stored in local application settings without a secure credential store
- Many SQL commands are built through string concatenation
- SQL Server connection strings are duplicated across forms
- The password-reset implementation is incomplete and contains an invalid update statement
- The committed BACPAC contains table data and requires privacy remediation
- Build outputs, IDE files, and package binaries are committed
- No automated tests
- The UI and previous documentation are Turkish

## Possible Future Improvements

- Parameterize every SQL command
- Move database configuration to one safe local configuration source
- Replace identifier-based sign-in with a password-hashing flow
- Publish a sanitized and reproducible demo database
- Refactor data access out of UI forms
- Correct and test the password-reset workflow
- Add validation and automated tests
- Remove generated build artifacts from version control

## Project Status

Portfolio learning project demonstrating C# Windows Forms, SQL Server, ADO.NET, CRUD operations, search, loan management, and barcode features. The included database package contains fictional demo data created for local testing and demonstration.

## Author and Contact

Ömer Yeşil

[GitHub](https://github.com/omeryssl) · [LinkedIn](https://www.linkedin.com/in/omer-yesil-developer/)
