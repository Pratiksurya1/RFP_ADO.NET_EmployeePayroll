ALTER PROCEDURE [dbo].[InsertDaba]
@name varchar(10)='',
@start_date date='2022-01-01',
@gender VARCHAR(1)='',
@basic_pay INT=0,
@deductions INT=0,
@taxable_pay INT=0,
@incometax INT=0,
@net_pay INT=0

AS
BEGIN
INSERT INTO employee_payroll(name,start_date,gender,basic_pay,deductions,taxable_pay,incometax,net_pay) VALUES(@name,@start_date,@gender,@basic_pay,@deductions,@taxable_pay,@incometax,@net_pay)
END