# My Virtual Factory Model

## Description

In this assignment, we will perform a virtual factory automation. Our virtual factory creates production 
orders according to the orders they receive. Its production order is planned on machines within the 
factory according to sub-operations in a production and a schedule is planned. The next level should 
be planned after the sub-operations are finished in the schedule for the product to emerge. Necessary 
data tables are provided for the identification of the system. The first column of each table is in the 
Primary Key property. In other tables with the same name, the real fields are in the ForeignKey 
property.

## Tables

**Customers (customer_id, name, password):** It is the table where customer information is stored.

**Users (user_id, name, password):** It is the membership information of the factory personnel that is 
kept for entering the system.

**Orders (order_id, customer_id, order_date, deadline):** It is the order information that customers 
send to the system. For each order information, the date of issue and termination, which is given by 
the user, is given.

**OrderItems (order_item_id, order_id, product_id, amount):** The order placed is pocketed from 
multiple items. Each order item stores information about a product and how much it is wanted to be 
produced.

**Products (product_id, product_name, product_type, is_salable):** The names of the products and 
plants are given in this table. Also, whether the product is a sub_product (intermediate product) is 
determined by the salable field. They can only view salable items.

**SubProductTree (sub_product_id, product_id, amount):** The sub-view required to produce a 
product and how many units of the child product per unit of product will be given in this table. A 
product production tree reviews from multiple levels. This table only holds one level relations. 
Ultimately, the product tree for which a product_id will be defined for one of them is kept in the 
form of multiple records in this table. For a product production, this table must be scanned and 
production orders must be generated if there is no production in the required sub-available stock.

**Operations (operation_id, operation_name, product_type):** This table will store the list of 
operations required to produce each product type.

**WorkCenters (work_center_id, work_center_name, active):** It is the table where the records of the 
machines in the factory are kept. It will determine whether this machine will be used in job planning 
as the active area as boolean.

**WorkCenterOperation (wc_opr_id, work_center_id, operation_id, speed):** Making a job base 
(machine) a job type (product / min) shows in the speed field. If there is no machine definition in this 
table for the relevant job type, this operation cannot be done. The user is alerted at this time. If there 
is more than one record for a job type, this job type can accomplished on more than one machine. 
The opposite means that a machine can do more than one job type.

## Features of the program

1. Customers and personal will log into your application from different login screen.

2. Customers will be able to create a basket defined in the system and place an order in client 
sessions. They will indicate the deadline they want in their orders. There can be more than one order item in an order.

3. Customers will be able to follow up the status of orders that have been placed before.

4. The staff will see the main prompt as summarized graphically on a dashboard.

  a. Orders - according to their condition
  
  b. Machines - job queues - availability
  
  c. Deadline misses, etc.
  
5. Staffs will be able to define system definitions, products, production tree, machines, operations, machine - operation - product relations systems.

6. When the staff wants to plan an order, they will be able to plan the order according to the empty time slots of the machines in accordance with the order.

7. Staff will be able to change the time slot of operations planned on one machine or transfer it to another machine capable of performing this work. This transfer process will be made byconsidering the conditions of the previous and the next operation in the product tree, such as the harmony of the processing time on the machine. If other operations in the product tree need to be shifted, the process should be tested for suitability.

## Migration Add

`` dotnet ef migraetions add Test ``

## Update Database

`` dotnet ef database update ``
