# InternetRadio

Internet Radio is a web application created in .NET Core technology, based on the MVC pattern.


## Dependencies

```bash
https://github.com/naudio/NAudio
```

## Usage

Listenable radio stations are in the ../Models/WebRadiosRepository.cs, you can add more...

### Web page

![2021-07-03_202533](https://user-images.githubusercontent.com/27755739/124363670-f1ee3200-dc3c-11eb-9f90-2c6d794c67db.png)


### Web API - Available commands

Play station
```bash
https://localhost:44374/apiradio/Play
{
    "name": "ChiliZet",
    "url": "https://ch.cdn.eurozet.pl/chi-net.mp3"
}
```

Add station 
```bash
https://localhost:44374/apiradio/addstation
{
    "name": "ChiliZet",
    "url": "https://ch.cdn.eurozet.pl/chi-net.mp3"
}
```


Remove station
```bash
https://localhost:44374/apiradio/removestation
{
    "name": "ChiliZet",
    "url": "https://ch.cdn.eurozet.pl/chi-net.mp3"
}
```

Increases the volume by 10%.
```bash
https://localhost:44374/apiradio/VolumeUp
```

Increases the volume by 20%.
```bash
https://localhost:44374/apiradio/VolumeUpUp
```

Decrease the volume by 10%.
```bash
https://localhost:44374/apiradio/VolumeDown
```

Decrease the volume by 20%.
```bash
https://localhost:44374/apiradio/VolumeDownDown
```
