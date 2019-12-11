import PropTypes from 'prop-types';
import { requireNativeComponent, View, ViewPropTypes } from 'react-native';

var iface = {
  name: 'InkCanvasView',
  propTypes: {
    width: PropTypes.number,
    height: PropTypes.number,
    ...ViewPropTypes // include the default view properties
  },
};

module.exports = requireNativeComponent('InkCanvasView', iface);