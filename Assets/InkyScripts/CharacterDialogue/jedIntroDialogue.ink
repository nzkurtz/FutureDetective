Hello detective.
* [Hi, who are you?]
    ->who
* [Hi, where were you on the night of the crime?]
    ->where
*[End conversation]
    ->END

===who===
My name is Jed. I work as a car mechanic in town.
    *[Where were you on the night of the crime?]
        ->where1
    *[End conversation]
        ->END

===where===
On the night of the crime I was at the shop repairing a car. I didn't come home until later in the night.
    *[Who are you?]
        ->who1
    *[End conversation]
        ->END
===who1===
My name is Jed. I work as a car mechanic in town.
        ->END
===where1===
On the night of the crime I was at the shop repairing a car. I didn't come home until later in the night.
        ->END