# W02 Assignment: Explain Abstraction

## Explain the meaning of Abstraction.

I would describe abstraction as managing complexity by exposing only the essential features of an object or system. This hides details and lets the program have a simpler interface.

## Highlight a benefit of Abstraction.

Some benefits of abstraction are that it hides internal details so that if the underlying code changes, the rest of the program doesn't break, and it simplifies how different parts of the code interact, making it easier to maintain.

## Provide an application of Abstraction.

An application of Abstraction would be a car's dashboard. The gas pedal makes the car go but you don't need to understand all the complexity of what is happening under the hood.

In the journal application, calling the `add_entry` will save the input without needing to know how the storage actually works.

## Use a code example of Abstraction from the program you wrote.

```csharp
foreach (Job job in _jobs)
{
    job.DisplayJob();
}
```

## Include the screenshot you took at the beginning of your team meeting.

![Team meeting screenshot 1](images/abstraction-meeting-1.png)

![Team meeting screenshot 2](images/abstraction-meeting-2.png)
