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

Returns all possible stations.
```bash
https://localhost:44374/apiradio/getallstation
```

```bash
https://localhost:44374/apiradio/addstation
{"name":"ChiliZett","url":"https://ch.cdn.eurozet.pl/chi-net.mp3"}
```

Returns the current volume.
```bash
192.168.1.50:5000/api/getVolume
```

Increases the volume by 15%. To decrease, enter the argument -15.
```bash
192.168.1.50:5000/api/setVolume/+15
```

Sets volume to 40.
```bash
192.168.1.50:5000/api/setVolume/40
```

Sets the station being played back to RNS. List of available stations in the file model.py.
```bash
192.168.1.50:5000/api/Play/RNS
```

Stops playing a station.
```bash
192.168.1.50:5000/api/Stop
```
