- [hairy-pineapple-gopro-lab :pineapple:](#hairy-pineapple-gopro-lab-pineapple)
  - [Code Structure :pencil2:](#code-structure-pencil2)
  - [Implementation Ideas :thought_balloon:](#implementation-ideas-thought_balloon)
  - [Tooling Ideas :toolbox:](#tooling-ideas-toolbox)
  - [Notes :spiral_note_pad:](#notes-spiral_note_pad)

# hairy-pineapple-gopro-lab :pineapple:
A .NET MAUI application that that allows user to capture configuration sets and apply these to a GoPro device on-demand.

## Code Structure :pencil2:

Projects as defined as follows:

| Project Name  | Description   | Tech / Packages Used   |
| :---          | :----         | :---                   |
| `Hairy.Pineapple.GoPro.Lab` | Primary .NET MAUI application. | .NET 6 Application |
| `Hairy.Pineapple.GoPro.Lab.Test` | xUnit unit test project (covering the primary application project). | xUnit and FluentAssertions. |

## Implementation Ideas :thought_balloon:

The ideas here listed here will change as I develop the application. GoPro does surface an API for HTTP and BlueTooth interactions, as described here:

- [General Open GoPro API Documentation](https://gopro.github.io/OpenGoPro/)
- [BlueTooth Low Energy (BLE) Specification v2.0](https://gopro.github.io/OpenGoPro/ble_2_0)
- [HTTP Specification v.2.0](https://gopro.github.io/OpenGoPro/http_2_0)

So some kind of interaction between the application and this API would be great. Initially, however, just allowing for the creation of multiple configurations (and storing this data) would be the first goal.

## Tooling Ideas :toolbox:

I have the following in mind, depending on how implementations pan out.

- Fluent validation and exceptions: [Throw](https://github.com/amantinband/throw)
- Custom Mapper logic: [Mapster](https://github.com/MapsterMapper/Mapster)
- BlueTooth LE: [32feet.NET](https://github.com/inthehand/32feet) (requires further investigation).
- Use of ViewModels and Commands, with DI.

## Notes :spiral_note_pad:

Currently designated as:

1. A pet project.
1. Targeting a GoPro Hero 10.

I am happy for the code to be used, lifted/shifted, etc. Just a cautionary note, however; I am a web developer (with some WPF experience) toying with .NET MAUI, so any code here should be examined by an authorative source before use. :sweat_smile:
