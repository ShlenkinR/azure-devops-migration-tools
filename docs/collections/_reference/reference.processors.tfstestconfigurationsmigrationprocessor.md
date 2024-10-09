---
optionsClassName: TfsTestConfigurationsMigrationProcessorOptions
optionsClassFullName: MigrationTools.Processors.TfsTestConfigurationsMigrationProcessorOptions
configurationSamples:
- name: defaults
  order: 2
  description: 
  code: There are no defaults! Check the sample for options!
  sampleFor: MigrationTools.Processors.TfsTestConfigurationsMigrationProcessorOptions
- name: sample
  order: 1
  description: 
  code: There is no sample, but you can check the classic below for a general feel.
  sampleFor: MigrationTools.Processors.TfsTestConfigurationsMigrationProcessorOptions
- name: classic
  order: 3
  description: 
  code: >-
    {
      "$type": "TfsTestConfigurationsMigrationProcessorOptions",
      "Enabled": false,
      "SourceName": null,
      "TargetName": null
    }
  sampleFor: MigrationTools.Processors.TfsTestConfigurationsMigrationProcessorOptions
description: This processor can migrate `test configuration`. This should be run before `LinkMigrationConfig`.
className: TfsTestConfigurationsMigrationProcessor
typeName: Processors
architecture: 
options:
- parameterName: Enabled
  type: Boolean
  description: If set to `true` then the processor will run. Set to `false` and the processor will not run.
  defaultValue: missing XML code comments
- parameterName: SourceName
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: TargetName
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
status: Beta
processingTarget: Suites & Plans
classFile: /src/MigrationTools.Clients.TfsObjectModel/Processors/TfsTestConfigurationsMigrationProcessor.cs
optionsClassFile: /src/MigrationTools.Clients.TfsObjectModel/Processors/TfsTestConfigurationsMigrationProcessorOptions.cs

redirectFrom:
- /Reference/Processors/TfsTestConfigurationsMigrationProcessorOptions/
layout: reference
toc: true
permalink: /Reference/Processors/TfsTestConfigurationsMigrationProcessor/
title: TfsTestConfigurationsMigrationProcessor
categories:
- Processors
- 
topics:
- topic: notes
  path: /docs/Reference/Processors/TfsTestConfigurationsMigrationProcessor-notes.md
  exists: false
  markdown: ''
- topic: introduction
  path: /docs/Reference/Processors/TfsTestConfigurationsMigrationProcessor-introduction.md
  exists: false
  markdown: ''

---