Library Network
---------------
Customer "Library Network" proposes to develop a prototype application for cataloging information about the objects stored in the library (books, magazines, newspapers, etc.).
Prototype must implement the following functionality:  
- Adding entries to the directory.
- Deleting entries from the directory.
- View catalog.
- Search by title.
- Sort by release year in direct and reverse order.
- Search book or author's name on the patent (inventor).
- Search all books (patents) by author's name (including those with whom he is co-author).

Сustomer Wishes
---------------
#### [Revision 1](#r1)
#### [Revision 2](#r2)

<a name="r1"></a>
Description of stored objects
-----------------------------
### Books
- Title
- Author (s)
- Place of publication (city)
- Publisher name
- year
- Number of pages
- Note
- International Standard Book Number (ISBN)

### Newspapers
- Title
- Place of publication (city)
- Publisher name
- Year
- Number of pages
- Note
- Issue Number
- Issue Date
- International Standard Serial Number edition (ISSN)

### Patents
- Title
- Inventor (s)
- Country
- Registration number
- Filing Date of Patent
- patent date
- Number of pages
- Note

<a name="r2"></a>
New features
------------
- Grouping records by year of publication.
- Create tests to verify the correctness of the restrictions on the field.

### Books
- Title - Title of the book. Can contain any characters . The maximum size of 300 characters. Is a required field .
- Author (s) - name one or more of the authors .
   - First name - contains Russian or Latin characters ( in the same name can not be present , and both) , begins with a capital letter . Maximum number of characters 50 .
   - Surname - contains Russian or Latin characters ( in the same family can not attend and those and others ) , begins with a capital letter . Maximum number of characters 200.
- Place of publication (city) - the name of the city where the book was published . Contains Russian or Latin characters ( in the same name can not be present , and both) , begins with a capital letter . Maximum number of characters 200.
- Publisher name - name of the publisher , who published the book. Can contain any characters . The maximum size of 300 characters.
- year - the year of publication of the book. First , must not be greater than the current one.
- Number of pages - the number of pages in the book ( greater than 0) .
- Note - notes about the book. Can contain any characters . Maximum number of characters is 2000 .
- ISBN - International Standard Book Number . ISBN consists of characters and 10 digits . Abbreviation ISBN and the first digit separated by a space . The code consists of four zones , separated by hyphens .
- country of origin or group of countries , the combined language edition - may have a value of 0-7 , 80-94 , 950-993 , 9940-9989 , and 99900-99999 ;
- Imprint Code ; (1 to 7 digits) .
- unique edition number (1 to 7 digits) ;
- check digit ( one digit . Either Arabic numeral from 0 to 9 , or the Roman X, meaning 10);
- Note: The code always consists of 10 digits can be neither more nor less, but the number of digits in different groups .