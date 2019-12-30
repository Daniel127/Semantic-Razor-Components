# Build status
[AzureBuildMaster]: https://dev.azure.com/Daniel127/Semantic%20UI%20Blazor%20Components/_apis/build/status/CI-Release?branchName=master
[AzureBuildMasterLink]: https://dev.azure.com/Daniel127/Semantic%20UI%20Blazor%20Components/_build/latest?definitionId=8&branchName=master

[AzureBuildDevelop]: https://dev.azure.com/Daniel127/Semantic%20UI%20Blazor%20Components/_apis/build/status/CI-Development?branchName=develop
[AzureBuildDevelopLink]: https://dev.azure.com/Daniel127/Semantic%20UI%20Blazor%20Components/_build/latest?definitionId=7&branchName=develop

[GithubActions]: https://github.com/Daniel127/SemanticUI-Razor-Components/workflows/Github%20CI/badge.svg
[GithubActionsLink]: https://github.com/Daniel127/SemanticUI-Razor-Components/actions

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=semanticui-razor-components&metric=alert_status)](https://sonarcloud.io/dashboard?id=semanticui-razor-components)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=semanticui-razor-components&metric=ncloc)](https://sonarcloud.io/dashboard?id=semanticui-razor-components)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=semanticui-razor-components&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=semanticui-razor-components)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=semanticui-razor-components&metric=bugs)](https://sonarcloud.io/dashboard?id=semanticui-razor-components)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=semanticui-razor-components&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=semanticui-razor-components)

| Branch          | Build Azure   | Build Github |
| :-------------: |:-------------:| :---:
| master          | [![Build Status Master][AzureBuildMaster]][AzureBuildMasterLink] | [![Actions Status][GithubActions]][GithubActionsLink] |
| develop         | [![Build Status Develop][AzureBuildDevelop]][AzureBuildDevelopLink] | |



# Blazor/Razor Semantic UI Components

These components aim to provide the same components that are available in Semantic UI React, but for the new Blazor framework

# Demo
You can clone this repository and execute the demo project to see the components in action, demo use Blazor WebAssembly

# How to use

- Add Semantic UI CSS, for example from CDN
``` html
<!DOCTYPE html>
<html lang="en">
    <head>
        ...
        <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/semantic-ui@2.4.2/dist/semantic.min.css" />
        ...
    </head>
    <body>
    ...
    </body>
</html>
```
- Add Nuget package
``` powershell
dotnet add package QD.Components.Semantic
```

- Add usings in __*_imports.razor*__
``` razor
@using QD.Components.Semantic.Elements
```

- Create amazing app

``` razor
@page "/buttons"
@using QD.Components.Semantic.Enums.Button
@using Icon = QD.Components.Semantic.Enums.Elements.Icon

...

<h2>Loading</h2>
<Icon loading name="@Icon.Spinner" />

...

<h2>Animated Button</h2>
<Button animated="@Animation.Horizontal">
    <ButtonContent visible>Text 1</ButtonContent>
    <ButtonContent hidden>Text 2</ButtonContent>
</Button>

...
```

# Features
## Elements
- [X] Button
- [X] Container
- [X] Divider
- [X] Flag
- [X] Icon
- [ ] Header
- [ ] Image
- [ ] Input
- [ ] List
- [X] Label
- [ ] Loader
- [ ] Placeholder
- [ ] Reveal
- [ ] Rail
- [ ] Segment
- [ ] Step

## Collections
- [ ] Breadcrumb
- [ ] Grid
- [ ] Form
- [ ] Menu
- [ ] Message
- [ ] Table

## Views
- [ ] Advertisement
- [ ] Card
- [ ] Comment
- [ ] Feed
- [ ] Item
- [ ] Statistic

## Modules
- [ ] Checkbox
- [ ] Accordion
- [ ] Dimmer
- [ ] Dropdown
- [ ] Embed
- [ ] Modal
- [ ] Popup
- [ ] Progress
- [ ] Search
- [ ] Rating
- [ ] Sidebar
- [ ] Sticky
- [ ] Tab
- [ ] Transition

## Behaviours
- [ ] Visibility

## Addons
- [ ] Confirm
- [ ] Mount Node
- [ ] Portal
- [ ] Pagination
- [ ] Radio
- [ ] Ref
- [ ] Responsive
- [ ] Select
- [ ] Text Area
- [ ] Transitionable Portal