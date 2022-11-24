import React from 'react';
import AddEditComponent from '../../component/AddEditComponent/AddEditComponent';

const AddEditView = ({ personList, updatePersonList }) => {

    /**
    * FUNCTION()
    */
  

    return (
        <div className='container'>
            <AddEditComponent personList={personList} AddPerson={AddPerson} />
        </div>
    );
}

export default AddEditView;
