# DVLD Project – Driving License Management System

## Overview
The Driving & Vehicle License Department (DVLD) system is designed to manage the issuance and administration of driving licenses. It encompasses a range of services to ensure the provision of safe drivers on the roads.

## Installation
- Restore the DVLD.bak file inside Database folder to SqlServer or any DBMS you have.
- Once you download the version you want, run the project and write the username 'admin' and password '1234'

### Technical Details
- **Framework**: WindForm (built on **.Net 8**)
- **C#** is used as the primary programming language.
- The system utilizes **ADO.NET** for data access, ensuring efficient interaction with the database.
- The system employs secure **password hashing** to protect user credentials.
- **Error logging** is implemented in the event viewer for better tracking and debugging of any issues.
- [**Version**: v1.0.0](https://github.com/saleh-bin-sumida/Driving_And_Vehicles_License_Department-DVLD/archive/refs/tags/v0.1.0.zip)
- [**Version**: v1.5.1](https://github.com/saleh-bin-sumida/Driving_And_Vehicles_License_Department-DVLD/archive/refs/tags/v1.5.1.zip)
  

## Services Offered
- **Issuance of First-Time License**: A service for applicants to obtain a driving license for the first time.
- **Re-examination Service**: Allows applicants who have failed a test to schedule a re-examination.
- **License Renewal Service**: For renewing existing driving licenses.
- **Duplicate License for Lost License**: Issuance of a replacement for a lost driving license.
- **Duplicate License for Damaged License**: Issuance of a replacement for a damaged driving license.
- **License Release Service**: Unblocking a driving license after paying the required fines.
- **International License Issuance**: Providing an international driving license to eligible applicants.

## Application Information
Applicants must submit a request for the desired service and pay the associated fees. The system will require the following information:
- Application number
- Application date
- Applicant's personal number (national ID)
- Type of service requested
- Application status (new, canceled, completed)
- Paid fees

## License Categories
The system offers various license categories, each with specific requirements:
- **Category 1**: Small Motorcycles
- **Category 2**: Heavy Motorcycles
- **Category 3**: Regular Driving (Cars)
- **Category 4**: Commercial Driving (Taxi/Limousine)
- **Category 5**: Agricultural Vehicles
- **Category 6**: Small and Medium Buses
- **Category 7**: Trucks and Heavy Vehicles

## System Management
The system provides functionalities for managing users, individuals, requests, tests, license categories, and license reservations.

## Requirements for License Application
Applicants must meet the age requirement for the desired category, not possess a license of the same category, provide valid personal documents, and complete the necessary education and training.

## Testing Process
Applicants must pass a series of tests in the following order:
1. Vision Test
2. Theoretical Test
3. Practical Driving Test

Upon passing all tests and meeting the conditions, a driving license is issued with a validity period as defined in the license category.

## Inquiry Service
The system allows for inquiries about licenses held by an individual using their national number or license number.

## Conclusion
The DVLD system streamlines the process of managing driving licenses, ensuring that all drivers meet the necessary safety standards.

















