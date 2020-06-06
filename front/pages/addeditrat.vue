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
    const ip = await this.$axios.$get('http://icanhazip.com')
    this.ip = ip
  }
}
}
</script>
<style scoped>

</style>
