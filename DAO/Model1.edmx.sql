
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/13/2018 20:35:25
-- Generated from EDMX file: F:\Proyectos .NET\Gestion\salud\DAO\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [consultorios];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_direccionciudad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[direcciones] DROP CONSTRAINT [FK_direccionciudad];
GO
IF OBJECT_ID(N'[dbo].[FK_medico_inherits_persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[personas_medico] DROP CONSTRAINT [FK_medico_inherits_persona];
GO
IF OBJECT_ID(N'[dbo].[FK_medicoconsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[consultas] DROP CONSTRAINT [FK_medicoconsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_medicoespecialidad_especialidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[medicoespecialidad] DROP CONSTRAINT [FK_medicoespecialidad_especialidad];
GO
IF OBJECT_ID(N'[dbo].[FK_medicoespecialidad_medico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[medicoespecialidad] DROP CONSTRAINT [FK_medicoespecialidad_medico];
GO
IF OBJECT_ID(N'[dbo].[FK_paciente_inherits_persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[personas_paciente] DROP CONSTRAINT [FK_paciente_inherits_persona];
GO
IF OBJECT_ID(N'[dbo].[FK_pacienteconsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[consultas] DROP CONSTRAINT [FK_pacienteconsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_personadatos_contacto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[datos_contactos] DROP CONSTRAINT [FK_personadatos_contacto];
GO
IF OBJECT_ID(N'[dbo].[FK_personadireccion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[personas] DROP CONSTRAINT [FK_personadireccion];
GO
IF OBJECT_ID(N'[dbo].[FK_personaobra_social_obra_social]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[personaobra_social] DROP CONSTRAINT [FK_personaobra_social_obra_social];
GO
IF OBJECT_ID(N'[dbo].[FK_personaobra_social_persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[personaobra_social] DROP CONSTRAINT [FK_personaobra_social_persona];
GO
IF OBJECT_ID(N'[dbo].[FK_tipo_consultaconsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[consultas] DROP CONSTRAINT [FK_tipo_consultaconsulta];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ciudades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ciudades];
GO
IF OBJECT_ID(N'[dbo].[consultas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[consultas];
GO
IF OBJECT_ID(N'[dbo].[datos_contactos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[datos_contactos];
GO
IF OBJECT_ID(N'[dbo].[direcciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[direcciones];
GO
IF OBJECT_ID(N'[dbo].[especialidades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[especialidades];
GO
IF OBJECT_ID(N'[dbo].[medicoespecialidad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[medicoespecialidad];
GO
IF OBJECT_ID(N'[dbo].[obras_sociales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[obras_sociales];
GO
IF OBJECT_ID(N'[dbo].[personaobra_social]', 'U') IS NOT NULL
    DROP TABLE [dbo].[personaobra_social];
GO
IF OBJECT_ID(N'[dbo].[personas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[personas];
GO
IF OBJECT_ID(N'[dbo].[personas_medico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[personas_medico];
GO
IF OBJECT_ID(N'[dbo].[personas_paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[personas_paciente];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[tipos_consultas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tipos_consultas];
GO
IF OBJECT_ID(N'[dbo].[usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ciudades'
CREATE TABLE [dbo].[ciudades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [denominacion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'consultas'
CREATE TABLE [dbo].[consultas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [precio] nvarchar(max)  NOT NULL,
    [fecha] nvarchar(max)  NOT NULL,
    [medico_Id] int  NOT NULL,
    [tipo_consulta_Id] int  NOT NULL,
    [paciente_Id] int  NOT NULL
);
GO

-- Creating table 'datos_contactos'
CREATE TABLE [dbo].[datos_contactos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [email_primario] nvarchar(max)  NOT NULL,
    [email_secundario] nvarchar(max)  NOT NULL,
    [tel_celular] nvarchar(max)  NOT NULL,
    [tel_fijo] nvarchar(max)  NOT NULL,
    [persona_Id] int  NOT NULL
);
GO

-- Creating table 'direcciones'
CREATE TABLE [dbo].[direcciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [calle] nvarchar(max)  NOT NULL,
    [numero] smallint  NULL,
    [piso] nvarchar(max)  NULL,
    [dpto] smallint  NULL,
    [ciudad_Id] int  NOT NULL
);
GO

-- Creating table 'especialidades'
CREATE TABLE [dbo].[especialidades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [denominacion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'obras_sociales'
CREATE TABLE [dbo].[obras_sociales] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [denominacion] nvarchar(max)  NOT NULL,
    [plus] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'personas'
CREATE TABLE [dbo].[personas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [dni] int  NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [apellido] nvarchar(max)  NOT NULL,
    [direccion_Id] int  NULL
);
GO

-- Creating table 'personas_medico'
CREATE TABLE [dbo].[personas_medico] (
    [matricula] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'personas_paciente'
CREATE TABLE [dbo].[personas_paciente] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'tipos_consultas'
CREATE TABLE [dbo].[tipos_consultas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(max)  NOT NULL,
    [precio] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'usuarios'
CREATE TABLE [dbo].[usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [tipo_usuario] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'medicoespecialidad'
CREATE TABLE [dbo].[medicoespecialidad] (
    [especialidades_Id] int  NOT NULL,
    [personas_medico_Id] int  NOT NULL
);
GO

-- Creating table 'personaobra_social'
CREATE TABLE [dbo].[personaobra_social] (
    [obras_sociales_Id] int  NOT NULL,
    [personas_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ciudades'
ALTER TABLE [dbo].[ciudades]
ADD CONSTRAINT [PK_ciudades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'consultas'
ALTER TABLE [dbo].[consultas]
ADD CONSTRAINT [PK_consultas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'datos_contactos'
ALTER TABLE [dbo].[datos_contactos]
ADD CONSTRAINT [PK_datos_contactos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'direcciones'
ALTER TABLE [dbo].[direcciones]
ADD CONSTRAINT [PK_direcciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'especialidades'
ALTER TABLE [dbo].[especialidades]
ADD CONSTRAINT [PK_especialidades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'obras_sociales'
ALTER TABLE [dbo].[obras_sociales]
ADD CONSTRAINT [PK_obras_sociales]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'personas'
ALTER TABLE [dbo].[personas]
ADD CONSTRAINT [PK_personas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'personas_medico'
ALTER TABLE [dbo].[personas_medico]
ADD CONSTRAINT [PK_personas_medico]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'personas_paciente'
ALTER TABLE [dbo].[personas_paciente]
ADD CONSTRAINT [PK_personas_paciente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'tipos_consultas'
ALTER TABLE [dbo].[tipos_consultas]
ADD CONSTRAINT [PK_tipos_consultas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'usuarios'
ALTER TABLE [dbo].[usuarios]
ADD CONSTRAINT [PK_usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [especialidades_Id], [personas_medico_Id] in table 'medicoespecialidad'
ALTER TABLE [dbo].[medicoespecialidad]
ADD CONSTRAINT [PK_medicoespecialidad]
    PRIMARY KEY CLUSTERED ([especialidades_Id], [personas_medico_Id] ASC);
GO

-- Creating primary key on [obras_sociales_Id], [personas_Id] in table 'personaobra_social'
ALTER TABLE [dbo].[personaobra_social]
ADD CONSTRAINT [PK_personaobra_social]
    PRIMARY KEY CLUSTERED ([obras_sociales_Id], [personas_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ciudad_Id] in table 'direcciones'
ALTER TABLE [dbo].[direcciones]
ADD CONSTRAINT [FK_direccionciudad]
    FOREIGN KEY ([ciudad_Id])
    REFERENCES [dbo].[ciudades]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_direccionciudad'
CREATE INDEX [IX_FK_direccionciudad]
ON [dbo].[direcciones]
    ([ciudad_Id]);
GO

-- Creating foreign key on [medico_Id] in table 'consultas'
ALTER TABLE [dbo].[consultas]
ADD CONSTRAINT [FK_medicoconsulta]
    FOREIGN KEY ([medico_Id])
    REFERENCES [dbo].[personas_medico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_medicoconsulta'
CREATE INDEX [IX_FK_medicoconsulta]
ON [dbo].[consultas]
    ([medico_Id]);
GO

-- Creating foreign key on [paciente_Id] in table 'consultas'
ALTER TABLE [dbo].[consultas]
ADD CONSTRAINT [FK_pacienteconsulta]
    FOREIGN KEY ([paciente_Id])
    REFERENCES [dbo].[personas_paciente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_pacienteconsulta'
CREATE INDEX [IX_FK_pacienteconsulta]
ON [dbo].[consultas]
    ([paciente_Id]);
GO

-- Creating foreign key on [tipo_consulta_Id] in table 'consultas'
ALTER TABLE [dbo].[consultas]
ADD CONSTRAINT [FK_tipo_consultaconsulta]
    FOREIGN KEY ([tipo_consulta_Id])
    REFERENCES [dbo].[tipos_consultas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tipo_consultaconsulta'
CREATE INDEX [IX_FK_tipo_consultaconsulta]
ON [dbo].[consultas]
    ([tipo_consulta_Id]);
GO

-- Creating foreign key on [persona_Id] in table 'datos_contactos'
ALTER TABLE [dbo].[datos_contactos]
ADD CONSTRAINT [FK_personadatos_contacto]
    FOREIGN KEY ([persona_Id])
    REFERENCES [dbo].[personas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_personadatos_contacto'
CREATE INDEX [IX_FK_personadatos_contacto]
ON [dbo].[datos_contactos]
    ([persona_Id]);
GO

-- Creating foreign key on [direccion_Id] in table 'personas'
ALTER TABLE [dbo].[personas]
ADD CONSTRAINT [FK_personadireccion]
    FOREIGN KEY ([direccion_Id])
    REFERENCES [dbo].[direcciones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_personadireccion'
CREATE INDEX [IX_FK_personadireccion]
ON [dbo].[personas]
    ([direccion_Id]);
GO

-- Creating foreign key on [Id] in table 'personas_medico'
ALTER TABLE [dbo].[personas_medico]
ADD CONSTRAINT [FK_medico_inherits_persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[personas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'personas_paciente'
ALTER TABLE [dbo].[personas_paciente]
ADD CONSTRAINT [FK_paciente_inherits_persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[personas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [especialidades_Id] in table 'medicoespecialidad'
ALTER TABLE [dbo].[medicoespecialidad]
ADD CONSTRAINT [FK_medicoespecialidad_especialidades]
    FOREIGN KEY ([especialidades_Id])
    REFERENCES [dbo].[especialidades]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [personas_medico_Id] in table 'medicoespecialidad'
ALTER TABLE [dbo].[medicoespecialidad]
ADD CONSTRAINT [FK_medicoespecialidad_personas_medico]
    FOREIGN KEY ([personas_medico_Id])
    REFERENCES [dbo].[personas_medico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_medicoespecialidad_personas_medico'
CREATE INDEX [IX_FK_medicoespecialidad_personas_medico]
ON [dbo].[medicoespecialidad]
    ([personas_medico_Id]);
GO

-- Creating foreign key on [obras_sociales_Id] in table 'personaobra_social'
ALTER TABLE [dbo].[personaobra_social]
ADD CONSTRAINT [FK_personaobra_social_obras_sociales]
    FOREIGN KEY ([obras_sociales_Id])
    REFERENCES [dbo].[obras_sociales]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [personas_Id] in table 'personaobra_social'
ALTER TABLE [dbo].[personaobra_social]
ADD CONSTRAINT [FK_personaobra_social_personas]
    FOREIGN KEY ([personas_Id])
    REFERENCES [dbo].[personas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_personaobra_social_personas'
CREATE INDEX [IX_FK_personaobra_social_personas]
ON [dbo].[personaobra_social]
    ([personas_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------