
# react-native-wants-software-dimming

## Getting started

`$ npm install react-native-wants-software-dimming --save`

### Mostly automatic installation

`$ react-native link react-native-wants-software-dimming`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-wants-software-dimming` and add `RNWantsSoftwareDimming.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNWantsSoftwareDimming.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNWantsSoftwareDimmingPackage;` to the imports at the top of the file
  - Add `new RNWantsSoftwareDimmingPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-wants-software-dimming'
  	project(':react-native-wants-software-dimming').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-wants-software-dimming/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-wants-software-dimming')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNWantsSoftwareDimming.sln` in `node_modules/react-native-wants-software-dimming/windows/RNWantsSoftwareDimming.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Wants.Software.Dimming.RNWantsSoftwareDimming;` to the usings at the top of the file
  - Add `new RNWantsSoftwareDimmingPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNWantsSoftwareDimming from 'react-native-wants-software-dimming';

// TODO: What to do with the module?
RNWantsSoftwareDimming;
```
  