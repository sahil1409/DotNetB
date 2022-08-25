import React from "react";

class School1 extends React.Component {
    constructor(props) {
        super(props);
        this.state = { Name: "St. Augustine's High School", Location: "Vasai"};
    }

    render() {
        return(
            <div>
                <h3>School Name: {this.state.Name} | Location: {this.state.Location}</h3>
            </div>
        );
    }
}


const School2 = ({std}) => {
    return (<h3>Class/Section: {std}</h3>);
}

export {School1, School2};