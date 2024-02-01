## Run file
[run.cmd](run.cmd)  
Location of **RS.EXE** depends on versions:  

C:\Program Files\Microsoft SQL Server\120\Tools\Binn  
OR  
C:\Program Files\Microsoft SQL Server\130\Tools\Binn  
OR  
C:\Program Files\Microsoft SQL Server Reporting Services\Shared Tools  
OR  
C:\Program Files\Microsoft Power BI Report Server\Shared Tools  

## Script file
[Upload_Multiple_RDL_files.rss](Upload_Multiple_RDL_files.rss)

## Configuration file
[Configuration.txt](Configuration.txt)  

Can have multiple lines, `path to local .rdl folder`,`folder on SSRS`:  
```
C:\Upload_Multiple_RDL_Files\SalesReports\,/SalesReports
C:\Upload_Multiple_RDL_Files\Aggregate\,/Aggregate
```