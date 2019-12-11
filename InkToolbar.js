import PropTypes from 'prop-types';
import { requireNativeComponent, View, ViewPropTypes } from 'react-native';

var iface = {
  name: 'InkToolbarView',
  propTypes: {
    ...ViewPropTypes // include the default view properties
  },
};

module.exports = requireNativeComponent('InkToolbarView', iface);