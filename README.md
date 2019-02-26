
# react-native-wants-software-dimming

Small native module to set [UIScreen wantsSoftwareDimming](https://developer.apple.com/documentation/uikit/uiscreen/1617821-wantssoftwaredimming). Only support iOS.

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

## Usage
```javascript
import RNWantsSoftwareDimming from 'react-native-wants-software-dimming';

RNWantsSoftwareDimming.enable();
```
