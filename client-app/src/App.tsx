import { useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [cities, setCities] = useState([]);

  useEffect(() => {
    axios.get('https://dataservice.accuweather.com/locations/v1/cities/autocomplete?apikey=GeigSgPbrCPL9QUvqYrG2Ikd0SYPfAwL&q=br').then(response => {
      console.log(response);
      setCities(response.data);
    })
  }, [])

  return (
    <div>
      <Header as='h2' icon='sun' content='Weather' />
      <List>
      {cities.map((city: any) => (
            <List.Item key={city.Key}>
              {city.LocalizedName}
            </List.Item>
          ))}
      </List>
    </div>
  );
}

export default App;
