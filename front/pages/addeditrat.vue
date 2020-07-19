<template id="">
  <div>
    <div class="form-group">
      <label for="inputEmail">Email address</label>
      <input type="email" class="form-control" id="inputEmail" aria-describedby="emailHelp" placeholder="majed@gymrat.com" maxlength="50">
      <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
    </div>
    <div class="form-group">
      <label for="inputFirstName">First name</label>
      <input type="text" class="form-control" id="inputFirstName" placeholder="Enter first name" maxlength="50">
    </div>
    <div class="form-group">
      <label for="inputLastName">Last name</label>
      <input type="text" class="form-control" id="inputLastName" placeholder="Enter last name" maxlength="50">
    </div>
    <div class="form-group form-check">
      <input type="checkbox" class="form-check-input" id="checkboxIsActive">
      <label class="form-check-label" for="checkboxIsActive">Is active</label>
    </div>
     <button type="button" v-on:click="saveRat" class="btn btn-primary">Save</button>
  </div>
</template>
<script type="text/javascript">
export  default {
  head (){

  },
  methods: {
  async saveRat() {
     await this.$axios.post('http://localhost:7071/api/graphql',
     {
    query: `
      mutation saveRat($id:String!, $emailId:String!, $firstName:String!, $lastName:String!, $createdDateTime:String, $updateDateTime:String , $isDeleted: Bool, $isActive: Bool) {
        saveRat(ratViewModel:{
          id:$id, emailId:$emailId, firstName:$firstName, lastName:$lastName, createdDateTime: $createdDateTime, updateDateTime: $updateDateTime, isDeleted: $isDeleted, isActive: $isActive) {
            id
            emailId
            firstName
            lastName
            createdDateTime
            updateDateTime
            isDeleted
            isActive
        }
      })
      }
    `,
    variables: {
      id: "123",
      emailId: "test@t.com",
      firstName:"Majed",
      lastName: "Samyal",
      createdDateTime: "",
      updateDateTime : "",
      isDeleted: false,
      isActive : true
    },
  },{
    headers: {
      'Content-Type': 'application/json'
    })
    .then(function(resposne){
      console.log(resposne);
    })
    .catch(function(error){
      console.log(error);
    });
  }
}
}
</script>
<style scoped>

</style>
