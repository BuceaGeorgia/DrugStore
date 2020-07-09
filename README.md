.NET application for managing the orders made to the pharmacy in a hospital
-the medical staff from a certain departament sends an order to the pharmacy with the required drugs and quantity
-the pharmacist picks an order and sends the corresponding drugs, then the order is deleted from database

features:
login - The user can be admin, pharmacist or medical staff

place order- The medical staff can send an order to the pharmacy with the corresponding details about drugs
            -The order appears as sent in on the pharmacist's window

take order- The pharmacist choses an order from the list
            -Sends the necessary drugs
            -The order is then deleted
            -The order appears as being finnished on the window of the medical staff

the data is stored in a Mssql database generated from code using Entity Framework 
the GUI is created as a Windows Forms Appplication
I used .NET Remoting to manage the connection between clients and server
