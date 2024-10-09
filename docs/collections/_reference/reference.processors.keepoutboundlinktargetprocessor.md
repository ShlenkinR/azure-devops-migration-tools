---
optionsClassName: KeepOutboundLinkTargetProcessorOptions
optionsClassFullName: MigrationTools.Clients.AzureDevops.Rest.Processors.KeepOutboundLinkTargetProcessorOptions
configurationSamples:
- name: defaults
  order: 2
  description: 
  code: There are no defaults! Check the sample for options!
  sampleFor: MigrationTools.Clients.AzureDevops.Rest.Processors.KeepOutboundLinkTargetProcessorOptions
- name: sample
  order: 1
  description: 
  code: There is no sample, but you can check the classic below for a general feel.
  sampleFor: MigrationTools.Clients.AzureDevops.Rest.Processors.KeepOutboundLinkTargetProcessorOptions
- name: classic
  order: 3
  description: 
  code: >-
    {
      "$type": "KeepOutboundLinkTargetProcessorOptions",
      "Enabled": false,
      "WIQLQuery": "Select [System.Id] From WorkItems Where [System.TeamProject] = @project and not [System.WorkItemType] contains 'Test Suite, Test Plan,Shared Steps,Shared Parameter,Feedback Request'",
      "TargetLinksToKeepOrganization": "https://dev.azure.com/nkdagility",
      "TargetLinksToKeepProject": "35537ca4-fac4-4fe6-8dd1-62e6c6a0684d",
      "CleanupFileName": "c:/temp/OutboundLinkTargets.bat",
      "PrependCommand": "start",
      "DryRun": true,
      "SourceName": null,
      "TargetName": null
    }
  sampleFor: MigrationTools.Clients.AzureDevops.Rest.Processors.KeepOutboundLinkTargetProcessorOptions
description: missing XML code comments
className: KeepOutboundLinkTargetProcessor
typeName: Processors
architecture: 
options:
- parameterName: CleanupFileName
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: DryRun
  type: Boolean
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: Enabled
  type: Boolean
  description: If set to `true` then the processor will run. Set to `false` and the processor will not run.
  defaultValue: missing XML code comments
- parameterName: PrependCommand
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: SourceName
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: TargetLinksToKeepOrganization
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: TargetLinksToKeepProject
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: TargetName
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: WIQLQuery
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
status: missing XML code comments
processingTarget: missing XML code comments
classFile: /src/MigrationTools.Clients.AzureDevops.Rest/Processors/KeepOutboundLinkTargetProcessor.cs
optionsClassFile: /src/MigrationTools.Clients.AzureDevops.Rest/Processors/KeepOutboundLinkTargetProcessorOptions.cs

redirectFrom:
- /Reference/Processors/KeepOutboundLinkTargetProcessorOptions/
layout: reference
toc: true
permalink: /Reference/Processors/KeepOutboundLinkTargetProcessor/
title: KeepOutboundLinkTargetProcessor
categories:
- Processors
- 
topics:
- topic: notes
  path: /docs/Reference/Processors/KeepOutboundLinkTargetProcessor-notes.md
  exists: false
  markdown: ''
- topic: introduction
  path: /docs/Reference/Processors/KeepOutboundLinkTargetProcessor-introduction.md
  exists: false
  markdown: ''

---