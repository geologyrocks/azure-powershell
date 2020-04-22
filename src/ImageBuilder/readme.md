<!-- region Generated -->
# Az.ImageBuilder
This directory contains the PowerShell module for the ImageBuilder service.

---
## Status
[![Az.ImageBuilder](https://img.shields.io/powershellgallery/v/Az.ImageBuilder.svg?style=flat-square&label=Az.ImageBuilder "Az.ImageBuilder")](https://www.powershellgallery.com/packages/Az.ImageBuilder/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 1.7.4 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.ImageBuilder`, see [how-to.md](how-to.md).
<!-- endregion -->

---
## Generation Requirements
Use of the beta version of `autorest.powershell` generator requires the following:
- [NodeJS LTS](https://nodejs.org) (10.15.x LTS preferred)
  - **Note**: It *will not work* with Node < 10.x. Using 11.x builds may cause issues as they may introduce instability or breaking changes.
> If you want an easy way to install and update Node, [NVS - Node Version Switcher](../nodejs/installing-via-nvs.md) or [NVM - Node Version Manager](../nodejs/installing-via-nvm.md) is recommended.
- [AutoRest](https://aka.ms/autorest) v3 beta <br>`npm install -g autorest@beta`<br>&nbsp;
- PowerShell 6.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g pwsh`<br>&nbsp;
- .NET Core SDK 2.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g dotnet-sdk-2.2`<br>&nbsp;

## Run Generation
In this directory, run AutoRest:
> `autorest`

---
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azure.noprofile.md
input-file:
  # - $(repo)/specification/imagebuilder/resource-manager/Microsoft.VirtualMachineImages/stable/2020-02-14/imagebuilder.json
  - $(repo)/specification/imagebuilder/resource-manager/Microsoft.VirtualMachineImages/preview/2019-05-01-preview/imagebuilder.json

title: ImageBuilder
module-version: 0.1.0
subject-prefix: ''

directive:
  - where:
      verb: Set
      subject: VirtualMachineImageTemplate
    remove: true
  - where:
      subject: VirtualMachineImageTemplateRunOutput
    set:
      subject: ImageBuilderRunOutput
  - where:
      subject: VirtualMachineImageTemplate
    set:
      subject: ImageBuilderTemplate
  - where:
      verb: New
      subject: ImageBuilderTemplate
    hide: true
  - where:
      subject: ImageBuilderTemplate
      parameter-name: ImageTemplateName
    set:
      alias: Name
  # - where:
  #     variant: ^Create$|^CreateViaIdentity$|^CreateViaIdentityExpanded$|^Update$|^UpdateViaIdentity$
  #   remove: true
  - where:
      variant: ^CreateExpanded$|^CreateViaIdentityExpanded$
    remove: true
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IImageTemplateInternal/, 'public partial interface IImageTemplateInternal');
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IResourceInternal/, 'public partial interface IResourceInternal');
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IImageTemplateSharedImageDistributorInternal/, 'public partial interface IImageTemplateSharedImageDistributorInternal');
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IImageTemplateManagedImageDistributorInternal/, 'public partial interface IImageTemplateManagedImageDistributorInternal');
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IImageTemplateDistributorInternal/, 'public partial interface IImageTemplateDistributorInternal');
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IImageTemplateVhdDistributorInternal/, 'public partial interface IImageTemplateVhdDistributorInternal');
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IImageTemplateCustomizerInternal/, 'public partial interface IImageTemplateCustomizerInternal');
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IImageTemplatePowerShellCustomizerInternal/, 'public partial interface IImageTemplatePowerShellCustomizerInternal');
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IImageTemplateRestartCustomizerInternal/, 'public partial interface IImageTemplateRestartCustomizerInternal');
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IImageTemplateWindowsUpdateCustomizerInternal/, 'public partial interface IImageTemplateWindowsUpdateCustomizerInternal');
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IImageTemplateShellCustomizerInternal/, 'public partial interface IImageTemplateShellCustomizerInternal');
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/internal partial interface IImageTemplateFileCustomizerInternal/, 'public partial interface IImageTemplateFileCustomizerInternal');
```