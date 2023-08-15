## What is SQLcl?
**[SQLcl](https://download.oracle.com/otn_software/java/sqldeveloper/sqlcl-latest.zip)** - is Java-based command-line tool for Oracle Database. Successor of SQL*Plus basically. [Docs](https://docs.oracle.com/en/database/oracle/sql-developer-command-line/index.html).
## WHat is Liquibase?
**Liquibase** is an [open-source](https://github.com/liquibase/liquibase) database-independent library for tracking, managing and applying database schema changes.
## Examples
Connect to database:
```bat
>sql user@tnsname
>sql user/password@tnsname
```
Generates changelogs for database objects:
```bat
SQL> lb genobject -type table -name zipcodes
SQL> lb genobject -type ords -name module
```
Generates changelogs and controller file for schema:
```bat
SQL> lb genschema
```
Applies the specified changelog to schema:
```bat
SQL> lb update -changelog controller.xml
```
Writes SQL to roll back the database to the requested state:
```bat
SQL> lb rollbacksql -changelog controller.xml -count 100
```
Creates multiple folders/files per component and install file:
```bat
SQL> lb genobject -type apex -application 101 -skipExportDate -expOriginalIds -split
```
Export the data from the indicated tables (only use for small metadata tables):
```bat
SQL> lb data - object TABLE_NAME1,TABLE_NAME2
```