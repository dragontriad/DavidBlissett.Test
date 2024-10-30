Technical Overview of Customer Management Solution (See https://youtu.be/hSKRs-CymCY)
This repository is a technical test submitted by David Blissett, showcasing a CRUD-based application built with ASP.NET Core. The solution is designed to manage customer records through a structured Web API backend and a Razor Pages frontend, demonstrating a clean separation of concerns and modularity in design.

Project Structure
The solution is organized into three main projects:

App (DavidBlissett.Test.App): An ASP.NET Core Razor Pages project that serves as the user interface for customer management. It provides pages for listing, adding, editing, and viewing customer details.
WebAPI (DavidBlissett.Test.WebAPI): An ASP.NET Core Web API project responsible for managing customer data. It handles all backend operations, including CRUD logic and data validation.
Shared (DavidBlissett.Test.Shared): A shared project containing models and common data structures, including the Customer model. This ensures data consistency across the API and UI layers.
Application Components
1. Customer Model (Shared)
The Customer class defines properties relevant to customer records, such as CustomerID, FirstName, LastName, Address1, Address2, PostCode, and TelephoneNumber.
Includes data annotations for validation, ensuring consistent data entry throughout the application.
2. Web API Layer (WebAPI)
CustomerController: Exposes RESTful API endpoints to manage customer data, providing endpoints for retrieval, creation, updating, and deletion.
Endpoints:
GET /api/customers: Retrieves all customers.
GET /api/customers/{id}: Retrieves a specific customer by ID.
POST /api/customers: Creates a new customer.
PUT /api/customers/{id}: Updates an existing customer.
DELETE /api/customers/{id}: Deletes a customer.
Customer Repository: Implements ICustomerRepository to provide in-memory data storage, simulating a database layer and handling business logic for CRUD operations.
Dependency Injection: The repository is registered in the DI container, allowing seamless dependency injection into the CustomerController.
3. Razor Pages UI (App)
The frontend UI uses Razor Pages to provide a simple interface for managing customer data. Key pages include:
Index.cshtml: Lists all customers.
Create.cshtml: A form to add new customers.
Edit.cshtml: An editable form for updating customer information.
Details.cshtml: Displays details of a selected customer.
CustomerDataService: A service class within the UI project that interacts with the Web API. This service encapsulates HTTP requests for CRUD operations, allowing the Razor Pages to seamlessly retrieve and submit data.
Form Validation: Utilizes ASP.NET Core’s data annotations to validate inputs, ensuring that required fields are completed and formatted correctly.
Data Flow and Architecture
UI to API Communication: The Razor Pages frontend communicates with the API layer via CustomerDataService, which manages data operations for the UI. Each CRUD action in the UI triggers a corresponding API call, keeping the frontend and backend in sync.
Data Storage: This solution uses an in-memory CustomerRepository for simulating data persistence, enabling quick setup and testing without requiring a database.
Validation and Error Handling:
Data validation is enforced through model data annotations, helping maintain consistent data quality.
API error handling ensures that appropriate responses are returned for successful and failed operations, with the UI reflecting these outcomes.
Key Design Considerations
Modularity: Each project layer serves a distinct purpose, promoting clean separation of concerns. Shared models ensure data consistency across the API and UI.
Scalability: The repository pattern in CustomerRepository facilitates scalability by making it easy to switch from in-memory data to a database if required.
Dependency Injection: The solution leverages ASP.NET Core’s built-in DI to manage service dependencies, promoting clean code structure and easy testability.
Setup and Running the Application
Prerequisites: Requires .NET Core SDK and a web browser.
Startup:
Run both the Web API (WebAPI) and the Razor Pages UI (App) simultaneously, either through Visual Studio’s multi-project startup or using command line.
Testing Functionality:
The UI is accessible via /customers and provides options to create, read, update, and delete customer records.
This technical test is structured to demonstrate a full stack solution for customer management, emphasizing modularity, API-first design, and ease of use across both the API and UI. The architecture allows for potential scaling and additional features if necessary.
