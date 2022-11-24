import React from 'react';
import ArrayComponent from '../../components/ArrayComponent/ArrayComponent';

const ContactListView = ({contactList, setcontactList}) => {


    return (
        <div>
             <h1>Contact list Works...</h1>
             <ArrayComponent 
                contactList = {contactList}
                setcontactList = {setcontactList}
             />

        </div>
    );
}

export default ContactListView;
