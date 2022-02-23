using Microsoft.EntityFrameworkCore.Migrations;

namespace OCPP.Core.Database.Migrations
{
    public partial class ConectorStatusView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
           @"
           CREATE OR REPLACE VIEW public.""ConnectorStatusView""
            AS
            SELECT 
                  cs.""ChargePointId""
                , cs.""ConnectorId""
                , cs.""ConnectorName""
                , cs.""LastStatus""
                , cs.""LastStatusTime""
                , cs.""LastMeter""
                , cs.""LastMeterTime""
                , t.""TransactionId""
                , t.""StartTagId""
                , t.""StartTime""
                , t.""MeterStart""
                , t.""StartResult""
                , t.""StopTagId""
                , t.""StopTime""
                , t.""MeterStop""
                , t.""StopReason""
            FROM public.""ConnectorStatus"" AS cs 
            LEFT OUTER JOIN public.""Transactions"" AS t ON
                t.""ChargePointId"" = cs.""ChargePointId"" AND t.""ConnectorId"" = cs.""ConnectorId""
            WHERE(t.""TransactionId"" IS NULL) OR
                  (t.""TransactionId"" IN
                      (SELECT MAX(t2.""TransactionId"") AS Expr1
                       FROM     public.""Transactions"" t2
                       GROUP BY t2.""ChargePointId"", ""ConnectorId""))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            DROP VIEW public.""ConnectorStatusView"" CASCADE;
            ");
        }
    }
}
