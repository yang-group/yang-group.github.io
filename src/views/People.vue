<template>
  <v-main>
    <Leader/>
    <Members :memberData="memberData" />
  </v-main>
</template>
<script>
import YAML from 'yamljs'
import Leader from '@/components/Leader.vue'
import Members from '@/components/Members.vue'
//
var nativeObject = YAML.load('./data/data.yml')
var jsonstr = JSON.stringify(nativeObject)
var jsondata = JSON.parse(jsonstr)

export default {
  components: {
    Leader,
    Members
  },
  data: () => ({
    memberData: jsondata.memberData
  })
}
</script>
