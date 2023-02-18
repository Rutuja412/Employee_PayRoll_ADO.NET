select * from Emp_Payroll
create procedure [dbo].[SpAddEmployeeDetails]
(
@EmployeeName varchar(255),
@PhoneNumber varchar(255),
@Address varchar(255),
@Department varchar(255),
@Gender char(1),
@BasicPay float,
@Deductions float,
@TaxablePay float,
@Tax float,
@NetPay float,
@StartDate Date
)
as
begin
insert into Emp_Payroll values
(
@EmployeeName,@BasicPay,@StartDate,@Gender,@PhoneNumber,@Address,@BasicPay,@Department,@Deductions,@TaxablePay,@Tax,@NetPay
)
end
GO

