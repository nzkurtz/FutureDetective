Hello Detective. *you hear a low growl from the dog in her arms*
    *[Hello, who are you?]
        ->who
    *[Where were you on the night of the crime?]
        ->where
    *[End conversation]
        -> END
===who===
My name is Jacklyn. I live alone... except for my dog!
    *[Where were you on the night of the crime?]
        ->where
    *[How long have you had the dog?]
        ->dog
    *[End conversation]
        ->END
===where===
On the night of the crime I was outside gardening. I heard a scream and then glass breaking.
    *[How long have you had your dog?]
        ->dog1
    *[End conversation]
        ->END
===dog===
I have had my dog since the death of my husband. So around 2 years.
    *[Where were you on the night of the crime?]
        ->where1
    *[End conversation]
        ->END
===where1===
On the night of the crime I was outside gardening. I heard a scream and then glass breaking.
    ->END
===dog1===
I have had my dog since the death of my husband. So around 2 years.
        ->END