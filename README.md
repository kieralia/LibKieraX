# LibKieraX
A collection of simple, yet quite useful data structures for C#.

# LibKieraX

Created for use in projects that require "Vector3Int" and "Vector2Int" Data-Structures.

Usage:

```cs
/* Declaration. */
Kiera3 position = new Kiera3 ( 1 , 2 , 3 ) ;

/* Access */
position.x = 7 ; // Sets the 'x' value to 7.

Console.WriteLine ( position.y.ToString ( ) ) ; // Prints '2'.

// Prints the structure like so, "1:2:3".
Console.WriteLine ( position.ToString ( ) ) ;
```

Available values are `﻿Kiera2﻿`, `﻿Kiera3﻿` and `﻿Kiera4﻿`.

# LibKieraXF

To be used in places where Multidimensional floating point Data-Structures are required.

Usage:

```cs
/* Declaration. */
Kiera3F locale = new Kiera3F ( 1.0f , 2.4f , 3.2f ) ;

/* Access */
locale.x = 1.0f / 2.0f ; // Sets the 'x' value to 1.0.

Console.WriteLine ( kiera3.y.ToString ( ) ) ; // Prints '2.4'.

// Prints the structure like so, "1:2.4:3.2".
Console.WriteLine ( locale.ToString ( ) ) ;
```

Available units are `﻿Kiera2﻿F`, `﻿Kiera3﻿F` and `﻿Kiera4﻿F`.
