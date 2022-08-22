import React from 'react';
import './Region.css';
class Region extends React.Component {
    constructor(props) {
        super(props);
        this.state = { Country: "India", State: "Maharashtra", District: "Palghar", City: "Vasai"};
    }

    render() {
        return(
            <div>
                <h1>I live in {this.state.State}, {this.state.Country}. The name of the City I live in is {this.state.City}.</h1>
            </div>
        );
    }
}
export default Region;