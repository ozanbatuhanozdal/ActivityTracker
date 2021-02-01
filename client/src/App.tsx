import React from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Button, Header, Icon } from 'semantic-ui-react';

class App extends React.Component{


  state={

    values:[],
    Name: ''
    
  }

  componentDidMount() {
    axios.get('https://localhost:5001/api/values').then((response) => {
      console.log(response);
      this.setState({
        values:response.data
      })
    })
    this.setState({
      Name:'nazım'
    })
  }
  

  render(){

    return(
      
      <div>
      <Header as='h2'>
      <Icon name='settings' />
      <Header.Content>
      Account Settings
      <Header.Subheader>Manage your preferences</Header.Subheader>
    </Header.Content>
  </Header>
      </div>
    )
  }
}

export default App;
