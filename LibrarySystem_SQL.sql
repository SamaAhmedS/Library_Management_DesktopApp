use DB;

CREATE TABLE [Admin] (
  [ID] INT,
  [Email] VARCHAR(50),
  [Password] VARCHAR(50),
  [First_Name] VARCHAR(50),
  [Second_Name] VARCHAR(50),
  [Role] VARCHAR(50),
  [Hire_Date] DATE,
  CONSTRAINT [PK_Admin] PRIMARY KEY ([ID])
)

CREATE TABLE [Student] (
  [ID] INT,
  [First_Name] VARCHAR(50),
  [Second_Name] VARCHAR(50),
  [Email] VARCHAR(50),
  [Password] VARCHAR(50),
  [is_Suspended] BIT,
  [Department] VARCHAR(10),
  [Joined_Date] DATE ,
  CONSTRAINT [PK_Student] PRIMARY KEY ([ID])
);

CREATE TABLE [Book] (
  [ID] INT,
  [Title] VARCHAR(50),
  [Publisher_ID] INT,
  [No_Copies] INT DEFAULT 0,
  [Admin_ID] INT,
  [BDate] DATE, 

  CONSTRAINT [PK_Book] PRIMARY KEY ([ID])
);
CREATE TABLE [Book_Copy] (
  [ID] INT,
  [Book_ID] INT,
  CONSTRAINT [PK_Book_Copy] PRIMARY KEY ([ID], [Book_ID]),
  CONSTRAINT [FK_Book_Copy_Book] FOREIGN KEY ([Book_ID]) REFERENCES [Book]([ID])
  ON DELETE CASCADE
  ON UPDATE CASCADE
);


CREATE TABLE [Publisher] (
  [ID] INT,
  [Name] VARCHAR(50),
  [Phone_Number] VARCHAR(50),
  [Address] VARCHAR(50),
  [Email] VARCHAR(50),
  [Admin_ID] INT,
  CONSTRAINT [PK_Publisher] PRIMARY KEY ([ID]),
  CONSTRAINT [FK_Publisher_Admin] FOREIGN KEY ([Admin_ID]) REFERENCES [Admin]([ID])
  ON DELETE CASCADE
  ON UPDATE CASCADE
);


CREATE TABLE [Author] (
  [ID] INT,
  [Name] VARCHAR(50),
  [Email] VARCHAR(50),
  [Admin_ID] INT,
  CONSTRAINT [PK_Author] PRIMARY KEY ([ID]),
  CONSTRAINT [FK_Author_Admin] FOREIGN KEY ([Admin_ID]) REFERENCES [Admin]([ID])
  ON DELETE CASCADE
  ON UPDATE CASCADE
);


CREATE TABLE [Book_Author] (
  [Book_ID] INT,
  [Publisher_ID] INT,
  CONSTRAINT [PK_Book_Author] PRIMARY KEY ([Book_ID], [Publisher_ID]),
  CONSTRAINT [FK_Book_Author_Book] FOREIGN KEY ([Book_ID]) REFERENCES [Book]([ID]),
  CONSTRAINT [FK_Book_Author_Publisher] FOREIGN KEY ([Publisher_ID]) REFERENCES [Publisher]([ID])
  ON DELETE CASCADE
  ON UPDATE CASCADE
);

alter table Book add CONSTRAINT [FK_Book_Publisher] FOREIGN KEY ([Publisher_ID]) REFERENCES [Publisher]([ID]);
alter table Book add CONSTRAINT [FK_Book_Admin] FOREIGN KEY ([Admin_ID]) REFERENCES [Admin]([ID]);

CREATE TABLE [Book_Loan] (
  [To_Date] DATE,
  [User_ID] INT,
  [Copy_ID] INT,
  [Book_ID] INT,
   [From_Date] DATE,
  CONSTRAINT [PK_Book_Loan] PRIMARY KEY ( [From_Date],[To_Date], [User_ID], [Copy_ID], [Book_ID]),
  CONSTRAINT [FK_Book_Loan_Book_Copy] FOREIGN KEY ([Copy_ID], [Book_ID]) REFERENCES [Book_Copy]([ID], [Book_ID]),
  CONSTRAINT [FK_Book_Loan_Student] FOREIGN KEY ([User_ID]) REFERENCES [Student]([ID])
  ON DELETE CASCADE
  ON UPDATE CASCADE
);
 