import React, { Component } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import InkCanvas from './InkCanvas'

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#F5FCFF',
  },
  inkCanvas: {
    marginTop: 20,
    backgroundColor: '#AAAAAA',
  },
});

const App = () =>
    <View style={styles.container}>
        <Text>
            This is react & MSInkCanvas
        </Text>
        <View style={styles.inkCanvas}>
            <InkCanvas width={500} height={500}/>
        </View>
    </View>

export default App