using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Homework.Migrations
{
    public partial class betaVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTasks_Contracts_ContractId",
                table: "JobTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTasks_Employees_EmployeeId",
                table: "JobTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTasks_Invoices_InvoiceId",
                table: "JobTasks");

            migrationBuilder.DropColumn(
                name: "Invoiced",
                table: "JobTasks");

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "JobTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "JobTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContractId",
                table: "JobTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTasks_Contracts_ContractId",
                table: "JobTasks",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTasks_Employees_EmployeeId",
                table: "JobTasks",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTasks_Invoices_InvoiceId",
                table: "JobTasks",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTasks_Contracts_ContractId",
                table: "JobTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTasks_Employees_EmployeeId",
                table: "JobTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTasks_Invoices_InvoiceId",
                table: "JobTasks");

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "JobTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "JobTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ContractId",
                table: "JobTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Invoiced",
                table: "JobTasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTasks_Contracts_ContractId",
                table: "JobTasks",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTasks_Employees_EmployeeId",
                table: "JobTasks",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTasks_Invoices_InvoiceId",
                table: "JobTasks",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");
        }
    }
}
