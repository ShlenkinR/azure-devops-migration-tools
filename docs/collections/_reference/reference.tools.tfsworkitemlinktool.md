---
optionsClassName: TfsWorkItemLinkToolOptions
optionsClassFullName: MigrationTools.Tools.TfsWorkItemLinkToolOptions
configurationSamples:
- name: defaults
  order: 2
  description: 
  code: >-
    {
      "MigrationTools": {
        "Version": "16.0",
        "CommonTools": {
          "TfsWorkItemLinkTool": {
            "Enabled": "True",
            "FilterIfLinkCountMatches": "True",
            "SaveAfterEachLinkIsAdded": "False"
          }
        }
      }
    }
  sampleFor: MigrationTools.Tools.TfsWorkItemLinkToolOptions
- name: sample
  order: 1
  description: 
  code: >-
    {
      "MigrationTools": {
        "Version": "16.0",
        "CommonTools": {
          "TfsWorkItemLinkTool": {
            "Enabled": "True",
            "FilterIfLinkCountMatches": "True",
            "SaveAfterEachLinkIsAdded": "False"
          }
        }
      }
    }
  sampleFor: MigrationTools.Tools.TfsWorkItemLinkToolOptions
- name: classic
  order: 3
  description: 
  code: >-
    {
      "$type": "TfsWorkItemLinkToolOptions",
      "Enabled": true,
      "FilterIfLinkCountMatches": true,
      "SaveAfterEachLinkIsAdded": false
    }
  sampleFor: MigrationTools.Tools.TfsWorkItemLinkToolOptions
description: missing XML code comments
className: TfsWorkItemLinkTool
typeName: Tools
architecture: 
options:
- parameterName: Enabled
  type: Boolean
  description: If set to `true` then the tool will run. Set to `false` and the processor will not run.
  defaultValue: missing XML code comments
- parameterName: FilterIfLinkCountMatches
  type: Boolean
  description: Skip validating links if the number of links in the source and the target matches!
  defaultValue: missing XML code comments
- parameterName: SaveAfterEachLinkIsAdded
  type: Boolean
  description: Save the work item after each link is added. This will slow the migration as it will cause many saves to the TFS database.
  defaultValue: false
status: missing XML code comments
processingTarget: missing XML code comments
classFile: /src/MigrationTools.Clients.TfsObjectModel/Tools/TfsWorkItemLinkTool.cs
optionsClassFile: /src/MigrationTools.Clients.TfsObjectModel/Tools/TfsWorkItemLinkToolOptions.cs

redirectFrom:
- /Reference/Tools/TfsWorkItemLinkToolOptions/
layout: reference
toc: true
permalink: /Reference/Tools/TfsWorkItemLinkTool/
title: TfsWorkItemLinkTool
categories:
- Tools
- 
topics:
- topic: notes
  path: /docs/Reference/Tools/TfsWorkItemLinkTool-notes.md
  exists: false
  markdown: ''
- topic: introduction
  path: /docs/Reference/Tools/TfsWorkItemLinkTool-introduction.md
  exists: false
  markdown: ''

---