import React from "react";

function Welcome1({name}) {
    return (<h3>Hello, {name}</h3>);
}

function Welcome2({name}) {
    return (<h3>Hello, {name}</h3>);
}

function Welcome3({name1}) {
    return (<h3>Hello, {name1}</h3>);
}

const Welcome4 = ({name2}) => {
    return (<h3>Hello, {name2}</h3>);
}

export { Welcome1, Welcome2 }; 
export default Welcome3;
export {Welcome4};