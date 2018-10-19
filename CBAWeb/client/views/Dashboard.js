import React from 'react';
import dotnetify from 'dotnetify';
import MuiThemeProvider from 'material-ui/styles/MuiThemeProvider';
import DownloadIcon from 'material-ui/svg-icons/file/cloud-download';
import UploadIcon from 'material-ui/svg-icons/file/cloud-upload';
import LatencyIcon from 'material-ui/svg-icons/notification/network-check';
import UserIcon from 'material-ui/svg-icons/action/face';
import { cyan600, pink600, purple600, orange600 } from 'material-ui/styles/colors';
import InfoBox from '../components/dashboard/InfoBox';
import Traffic from '../components/dashboard/Traffic';
import ServerUsage from '../components/dashboard/ServerUsage';
import Utilization from '../components/dashboard/Utilization';
import RecentActivities from '../components/dashboard/RecentActivities';
import globalStyles from '../styles/styles';
import ThemeDefault from '../styles/theme-default';
import auth from '../auth';

class Dashboard extends React.Component {

  constructor(props) {
    super(props);
    this.vm = dotnetify.react.connect("Dashboard", this, {
      exceptionHandler: ex => {
         alert(ex.message);
         auth.signOut();
      }
    });
    this.dispatch = state => this.vm.$dispatch(state);

    this.state = {
    };
  }

  componentWillUnmount() {
    this.vm.$destroy();
  }

  render() {
    return (
      <MuiThemeProvider muiTheme={ThemeDefault}>
        <div>
          <h3 style={globalStyles.navigation}>Application / Dashboard</h3>

          <div className="row">

          </div>
        </div>
      </MuiThemeProvider>
    );
  }
}

export default Dashboard;
