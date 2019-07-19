# Bagheera's Bakery

#### _A console application for placing an order at a bakery - July 19, 2019_

#### _By **Na Hyung Choi**_

## Description

In this application, the user can specify the number of loaves of bread and the number of pastries to order, then see the total cost for the order. Discounts apply for 3-packs of bread and 3-packs of pastries. After placing the initial order, the user can add more items to the order if they wish, as many times as they want, and see the updated cost with each addition.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Charges $5 for 1 loaf of bread and $2 for 1 pastry** | 1 loaf of bread, 1 pastry | $5 + $2 = $10 total |
| **Charges $10 for 3 loaves of bread and $5 for 3 pastries** | 6 loaves of bread, 4 pastries | $20 + $7 = $27 total |
| **Allows adding additional loaves of bread or pastries to existing order** | Add 2 more pastries to above order | $20 + $10 = $30 total |


## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone https://github.com/schoinh/bakery.git
    ```
2. Run the application
    ```
    $ dotnet run
    ```

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C# / .NET

## Support and contact details

_Please contact Na Hyung with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Na Hyung Choi_**
