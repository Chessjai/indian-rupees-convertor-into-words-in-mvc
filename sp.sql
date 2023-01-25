

create procedure sp_Insertdata
(
@Input nvarchar(500),
@Output nvarchar(500)
)
as
begin
		Insert into tbl_Currencys(Input,output)
		values(@Input,@Output)
		end
		execute sp_Insertdata '123','One Hundred Twenty Three';

		select * from tbl_Currencys

		create table tbl_Currencys(
		Id int primary key identity(1,1),
		Input bigint,
		Output nvarchar(500)
		)
