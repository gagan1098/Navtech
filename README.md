# Order Placement APIs

## Problem Statement

### Develop an order workflow with RESTful APIs where API clients will be able to:
- Create orders. Order shall have order information and items.
- Create customers. System shall not allow to add new customer with already existing customer email.
- Retrieve list of orders based on specific page index and page size.

## Design

There are 3 APIs:

### GET API /api/Order: To get list of orders in paginated format

- Query params
	- pageSize: int
	- pageIndex: int

Status code
	- 200: OK

### POST API /api/Order: To create a new order

- Payload
```
[ { "orderId": 0, "orderStatus": "string", "placedTime": "2023-08-07T17:50:24.423Z", "updatedTime": "2023-08-07T17:50:24.423Z", "items": 0 } ]
```
Status code

	- 200: OK
	- 400: Bad Request
	
### POST API /api/Customer: To create a new customer

Payload
```
{ "customerId": 0, "firstName": "string", "lastName": "string", "mobileNumber": "string", "address": "string", "email": "string", "timeCreated": "2023-08-07T17:50:07.962Z" }
```
Status code

	- 200: OK
	- 400: Bad Request

## Approach

- Created 2 tables namely Order and Customer with corresponding properties
- Created controllers for each of the models constructed before
- Created DataContexts for each of the models constructed before
- Introduced validations on request parameters
- Handled various exceptions, e.g. when an order is created with existing orderId
- Tried to add UTs to ensure 100% code coverage

## Difficulties

- I found it bit challenging to figure out how to establish MySQL connection from Visual Studio to MS Server. After some debugging I discovered that parameter `TrustServerCertificate=True` was missing from connection string. After using this required parameter I was able to connect ORM with MS Server.
- Faced difficulty figuring out how to display product details in GET API `/api/Order` along with order details, due to unfamiliarity with JOIN statements in Entity Framework.
- Since I haven't written UTs before in ASP.NET, it was a bit tedious task to figure out how to write them. After some struggle, I was able to write UTs for success scenarios for OrderController and CustomerController.
