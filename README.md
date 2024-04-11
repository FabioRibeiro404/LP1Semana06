### Flowchart

```mermaid
 classDiagram
Color <|-- Program : Use
Sphere <|-- Program : Use

Program : Color c1
Program : int currentColo1
Program : int currentColo2
Program : int currentColo3
Program : Color color1
Program : Color c2
Program : int currentColo4
Program : int currentColo5
Program : int currentColo6
Program : Color color2

Color : +Red
Color : +Green
Color : Blue
Color : +Alpha
Color : +Gray

Sphere : +Radius
Sphere : +BallColor
Sphere : +NumberOfThrown
Sphere : +Thrown(): int
Sphere : +Pop(): int
Sphere : +GetTimesThrown(): int



```
