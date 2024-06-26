This project demonstrates the setup of a microservices architecture using .NET Core and Ocelot as the API Gateway. It involves creating multiple services and configuring an API Gateway to route and manage communication between these services efficiently.

**Features**

Microservices Architecture: Independent services that handle specific business logic, allowing for scalability and flexibility.
Ocelot API Gateway: Centralized entry point for managing routing, load balancing, and security.
Scalability and Fault Isolation: Each service can be developed, deployed, and scaled independently, ensuring robust fault isolation.

**Architecture**
<img width="1200" alt="ocuelet" src="https://github.com/rexer101/MicroService-Communication-with-Consul/assets/17480601/d2c73a11-a2c7-4734-bfbe-d9492066ee6c">

Client: Consumes the services.

WebApi: Acts as an intermediary, forwarding client requests to the API Gateway.

API Gateway: Uses Ocelot to route requests to the appropriate downstream services.

FirstService and SecondService: Backend microservices that handle specific tasks.

**Getting Started**

Clone the Repository:
git clone https://github.com/your-repo/microservices-architecture.git

**Build and Run Services:**

cd FirstService

dotnet run --urls=http://localhost:5002

cd ../SecondService

dotnet run --urls=http://localhost:5003

cd ../GateWay

dotnet run --urls=http://localhost:5001

cd ../WebApi

dotnet run --urls=http://localhost:5000


Test the Setup:

http://localhost:5000/firstservice/WeatherForecast

http://localhost:5000/secondservice/WeatherForecast

By following this guide, you will have a functional setup of a microservices architecture using .NET Core and Ocelot as the API Gateway, enhancing the scalability, flexibility, and fault isolation of your backend infrastructure.
