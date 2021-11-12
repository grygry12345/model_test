# My Virtual Factory Model

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

## Migration Add

`` dotnet ef migraetions add Test ``

## Update Database

`` dotnet ef database update ``
