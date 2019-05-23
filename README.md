# AccountDataStandardizerForToogoodFinancial


The  Transform System:

- In this project I designed IDataReader interface so we can add new Data Readers to read data from new sources (XML, CSV, Database etc.)
	I also designed IDataFormatter interface so we can add new data formatters for new formats.
	These interfaces are independent, because one is about format of data and the other is about source of it. For example you can have same format of data read from different sources (CSV, XML, etc.).

- I use dependency injection in DataConverter's Convert method to make this unit more reusable and testable. It takes an IDataReader and an IDataFormatter.

-The design I explained above makes this solution flexible and extensible. 
  I have also kept the code simple by seperating classes/concepts and providing in-code comments to make sure the code is maintainable.

- As stated in the system description, I did not fully design a data reader to read/convert data from CSV.
	Instead I provided mock data readers that provide a few rows so you can see the application in action.
	These mock classes also demonstrate how we can use mocking in our unit testing (MS Test, NUnit, etc.).
 

The Question:
Describe key principles for writing secure code.

We should make our code as secure as possible to potential attacks. 
The developers usually focus on providing working solutions and they miss the fact that exposing too many access points makes the code vulnerable against hacker attacks.
Developing teams should pay attantion to this fact during designing stage, implementation stage and testing.
Some of the secure code principles include: 
- Least privillege
- Defense in depth
- Fail securely.
- Default deny.
- Validate Inputs
