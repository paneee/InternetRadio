# InternetRadio

Internet Radio is a web application created in .NET Core technology, based on the MVC pattern.


## Dependencies

```bash
https://github.com/naudio/NAudio
```

## Usage

Listenable radio stations are in the ../Models/WebRadiosRepository.cs, you can add more...

### Web page

![2021-07-03_191433](https://user-images.githubusercontent.com/27755739/124363168-067cfb00-dc3a-11eb-96bb-debc0d124c9d.png)


### Web API - Available commands

Returns all possible stations.
```bash
192.168.1.50:5000/api/getAllStation
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
